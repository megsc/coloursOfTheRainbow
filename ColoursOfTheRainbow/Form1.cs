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
        /// <summary>
        /// An array of Colour objects
        /// </summary>
        Colour[] newColour;

        public Main()
        {
            InitializeComponent();

            string json;

            // Reading json file into array of Colour objects.
            using (StreamReader file = new StreamReader(@"../../../colours.json"))
            {
                
                json = file.ReadToEnd();
                newColour = JsonConvert.DeserializeObject<Colour[]>(json);
            }


        }

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            string colourList = string.Empty;

            listView1_showColour.Items.Clear();

            // Loading listview with specified columns.
            listView1_showColour.View = View.Details;

            // Looping through array of Colour objects to populate listview.
            for (int j = 0; j < newColour.Length; j++)
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = newColour[j].name;
                lvi.SubItems.Add(newColour[j].hex);
                lvi.SubItems.Add(newColour[j].rgb);

                listView1_showColour.Items.Add(lvi);


            }

            // Sorting listview items alphabetically.
            listView1_showColour.Sorting = SortOrder.Ascending;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddColour_Click(object sender, EventArgs e)
        {
            // Adding user input from textbox to variables.
            string addColName = textBox3_AddName.Text;
            string addColHex = textBox4_AddHex.Text;
            string addColRgb = textBox1_AddRGB.Text;

            // Creating char array's to verify user input.
            char[] hex = addColHex.ToCharArray();
            char[] rgb = addColRgb.ToCharArray();

            // 
            if (NameVerify(addColName))
            {
                if (HexFormat(hex))
                {
                    if (RGBFormat(rgb))
                    {
                        WriteToJson(addColName, addColHex, addColRgb);
                    }
                }
            }
   
            textBox3_AddName.Clear();
            textBox4_AddHex.Clear();
            textBox1_AddRGB.Clear();

        }


        // Fill picturebox with colour that is selected from listview.
        private void listView1_showColour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int j = 0; j < listView1_showColour.SelectedItems.Count; j++)
            {
                string name = listView1_showColour.SelectedItems[0].Text;

                pictureBox1_colourSample.BackColor = Color.FromName(name);

            }
        }


        /// <summary>
        /// Method to verify if Colour Name is found in the Color library.
        /// </summary>
        /// <param name="addColName"></param>
        /// <returns></returns>
        public bool NameVerify(string addColName)
        {
            // Checking that Colour Name entered is known in the Colour Library.
            if (Color.FromName(addColName).IsKnownColor == false)
            {
                MessageBox.Show("Colour reference not found. Colour not entered");
                return false;
            }

            // Checking that RGB and HEX codes have been entered and textbox are not null.
            else if (Color.FromName(addColName).IsKnownColor == true && textBox1_AddRGB.Text == "" && textBox4_AddHex.Text == "")
            {
                MessageBox.Show("Please add colour Hex code and RGB code");
                return false;
            }

            else
            {
                return true;
            }

        }

        /// <summary>
        /// Method to verify if Hex Colour code has been entered in the correct format by the user.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public bool HexFormat(char[] hex)
        {
            if (hex[0] != '#')
            {
                MessageBox.Show("Please enter Hex code starting with #");
                return false;
            }

            else if (hex.Length < 7 || hex.Length > 7)
            {
                MessageBox.Show("Please enter Hex code with 7 characters starting with #");
                return false;
            }

            else
            {
                return true;
            }

           
        }


        /// <summary>
        /// Method to verify if RGB Colour code has been entered in the correct format by the user.
        /// </summary>
        /// <param name="rgb"></param>
        /// <returns></returns>
        public bool RGBFormat(char[] rgb)
        {
            if (rgb.Length < 11 || rgb.Length > 11)
            {
                MessageBox.Show("Please enter RGB code with 11 characters using format: 111,111,111");
                return false;
            }

            // Verify that RGB code is entered in RGB format.
            else if (rgb[3] != ',')
            {
                MessageBox.Show("Please enter RGB code with 11 characters using format: 111,111,111");
                return false;
            }

            else if (rgb[7] != ',')
            {
                MessageBox.Show("Please enter RGB code with 11 characters using format: 111,111,111");
                return false;
            }

            else
            {
                return true;
            }

          
        }

        /// <summary>
        /// Method to write new Colour to json file using user input from form.
        /// </summary>
        /// <param name="addColName"></param>
        /// <param name="addColHex"></param>
        /// <param name="addColRgb"></param>
        public void WriteToJson(string addColName, string addColHex, string addColRgb)
        {
            // Add new instance into the array.
            Array.Resize(ref newColour, newColour.Length + 1);

            newColour[newColour.Length - 1] = new Colour();

            newColour[newColour.Length - 1].name = addColName;
            newColour[newColour.Length - 1].hex = addColHex;
            newColour[newColour.Length - 1].rgb = addColRgb;

            // Format array into json.
            string nc = JsonConvert.SerializeObject(newColour, Formatting.Indented);

            // Write array to json file.
            File.WriteAllText(@"../../../colours.json", nc);

            // Tell the user Colour has been added.
            MessageBox.Show(addColName + " with Hex " + addColHex + " and RGB of " + addColRgb + " has been added!");
        }

    }
 
}
