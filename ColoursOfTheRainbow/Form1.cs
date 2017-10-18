using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;


namespace ColoursOfTheRainbow
{
    public partial class Main : Form
    {
        Colour[] newColour;

        public Main()
        {
            InitializeComponent();

            string json;

            //using (StreamReader file = new StreamReader(@"../../../test.json"))
            using (StreamReader file = new StreamReader(@"../../../colours.json"))
            {
                
                json = file.ReadToEnd();
                newColour = JsonConvert.DeserializeObject<Colour[]>(json);
            }

            
            //MessageBox.Show(newColour[0].name + newColour[0].hex);

            //Colour newColour = JsonConvert.DeserializeObject<Colour>(File.ReadAllText(Properties.Resources.colours));


        }

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            string colourList = string.Empty;

            //for (int j = 0; j < newColour.Length; j++)
            //{
            //    colourList += "Colour: " + newColour[j].name + " has Hex code: " + newColour[j].hex + newColour[j].rgb + Environment.NewLine;
            //}

            //MessageBox.Show(colourList);

            listView1_showColour.Items.Clear();

            listView1_showColour.View = View.Details;

            for (int j = 0; j < newColour.Length; j++)
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = newColour[j].name;
                lvi.SubItems.Add(newColour[j].hex);
                lvi.SubItems.Add(newColour[j].rgb);

                listView1_showColour.Items.Add(lvi);


            }

            listView1_showColour.Sorting = SortOrder.Ascending;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddColour_Click(object sender, EventArgs e)
        {
            string addColName = textBox3_AddName.Text;
            string addColHex = textBox4_AddHex.Text;
            string addColRgb = textBox1_AddRGB.Text;

            //textBox1_AddRGB.TextChanged += TextBox1_AddRGB_TextChanged;
            //textBox4_AddHex.TextChanged += TextBox4_AddHex_TextChanged;

            char[] hex = addColHex.ToCharArray();
            char[] rgb = addColRgb.ToCharArray();


            if (Color.FromName(addColName).IsKnownColor == false)
            {
                MessageBox.Show("Colour reference not found. Colour not entered");
            }

            else if (Color.FromName(addColName).IsKnownColor == true && textBox1_AddRGB.Text == "" && textBox4_AddHex.Text == "")
            {
                MessageBox.Show("Please add colour Hex code and RGB code");
            }

            else
            {
                if (hex[0] != '#')
                {
                    //textBox4_AddHex.TextChanged -= TextBox4_AddHex_TextChanged;
                    MessageBox.Show("Please enter Hex code starting with #");
                }

                else if (hex.Length < 7 || hex.Length > 7)
                {
                    //textBox4_AddHex.TextChanged -= TextBox4_AddHex_TextChanged;
                    MessageBox.Show("Please enter Hex code with 7 characters starting with #");
                }

                else if (rgb.Length < 11 || hex.Length > 11)
                {
                    MessageBox.Show("Please enter RGB code with 11 characters using format: 111,111,111");
                }

                else if (rgb[3] != ',' && rgb[7] != ',')
                {
                    MessageBox.Show("Please enter RGB code with 11 characters using format: 111,111,111");
                }

                else
                {
                    Array.Resize(ref newColour, newColour.Length + 1);

                    newColour[newColour.Length - 1] = new Colour();

                    newColour[newColour.Length - 1].name = addColName;
                    newColour[newColour.Length - 1].hex = addColHex;
                    newColour[newColour.Length - 1].rgb = addColRgb;


                    string nc = JsonConvert.SerializeObject(newColour, Formatting.Indented);
                    //string nc = JsonConvert.SerializeObject(addCol, Formatting.Indented);
                    //File.WriteAllText(@"../../../test.json", nc);
                    File.WriteAllText(@"../../../colours.json", nc);

                    MessageBox.Show(addColName + " with Hex " + addColHex + " and RGB of " + addColRgb + " has been added!");
                }

                
            }

            textBox3_AddName.Clear();
            textBox4_AddHex.Clear();
            textBox1_AddRGB.Clear();
        }



        private void listView1_showColour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int j = 0; j < listView1_showColour.SelectedItems.Count; j++)
            {
                string name = listView1_showColour.SelectedItems[0].Text;

                pictureBox1_colourSample.BackColor = Color.FromName(name);

            }
        }




    }
    
}
