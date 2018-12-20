using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ips.Tlv;
using Ips.Tlv.Emv;
using System.IO;
//using System.Text.RegularExpressions;

namespace TlvReader
{
    public partial class TlvReader : Form
    {
        //private bool valueHEX = false;

        public TlvReader()
        {
            InitializeComponent();

            //dataGridViewTLV.TopLeftHeaderCell.

            //Setting up DataGridView
            dataGridViewTLV.ColumnCount = 5;
            dataGridViewTLV.Columns[0].Name = "TLV Tag Name";
            dataGridViewTLV.Columns[0].Width = 125;
            dataGridViewTLV.Columns[1].Name = "TLV Tag Code";
            dataGridViewTLV.Columns[1].Width = 115;
            dataGridViewTLV.Columns[2].Name = "Value (ASCII)";
            dataGridViewTLV.Columns[2].Width = 150;
            dataGridViewTLV.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTLV.Columns[3].Name = "Value (HEX)";
            dataGridViewTLV.Columns[3].Width = 150;
            dataGridViewTLV.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTLV.Columns[4].Name = "Type";
            dataGridViewTLV.Columns[4].Width = 100;

            dataGridViewTLV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTLV.MultiSelect = false;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            try
            {
                string hex = this.txtHex.Text.Replace(",", "").Trim();
                var standardSerializer = new TlvSerializer(EmvTagMap.FullDefault);
                var tlvs = standardSerializer.Deserialize(hex);
                populateGrid(tlvs, standardSerializer);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionExtensions.ToDetailedString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    var filebytes = File.ReadAllBytes(openFileDialog1.FileName);
                    var standardSerializer = new TlvSerializer(EmvTagMap.FullDefault);
                    var tlvs = standardSerializer.Deserialize(filebytes);
                    populateGrid(tlvs, standardSerializer);
                    string hex = Ips.Tlv.ByteConverter.ByteArrayToHexString(filebytes);
                    txtHex.Text = hex;

                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionExtensions.ToDetailedString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateGrid(IEnumerable<ITlvNode> tlvs, TlvSerializer standardSerializer)
        {
            foreach (var item in tlvs)
            {
                var tag = standardSerializer.TagMap[item.Tag];
                string strValue = item.Value.ToString();
                string hexvalue = "";

                if (tag.TlvType == TlvType.Binary)
                {
                    strValue = null;
                    strValue = bytearraytostring((byte[])item.Value);
                    hexvalue = Ips.Tlv.ByteConverter.ByteArrayToHexString((byte[])item.Value);
                }
                else
                {
                    foreach (char c in strValue)
                    {
                        hexvalue += String.Format("{0:X2}", Convert.ToInt32(c));
                    }
                }

                dataGridViewTLV.Rows.Add(tag.Name, tag.Tag.ToString("X"), strValue, hexvalue, tag.TlvType);
            }
        }

        private void clearForm()
        {
            txtHex.Text = null;
            dataGridViewTLV.Rows.Clear();
            dataGridViewTLV.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionExtensions.ToDetailedString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeCellValue(int rownum, int colnum, string value)
        {
            dataGridViewTLV[colnum, rownum].Value = value;
        }

        private string bytearraytostring(byte[] arr)
        {
            string strValue = null;
            foreach (var element in (byte[])arr) { strValue += element + " "; }
            return strValue;
        }
    }
}
