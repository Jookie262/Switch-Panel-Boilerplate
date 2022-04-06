using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_panel_boilerplate
{
    public partial class Form1 : Form
    {
        // Create a list of panels that switches
        List<Panel> panel_list = new List<Panel>();

        // Index of the current panel
        int index; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add the needed panels 
            panel_list.Add(panel1);
            panel_list.Add(panel2);
            panel_list.Add(panel3);

            // Display the first panel in front
            panel_list[index].BringToFront();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            // If the index is less than the total panel inside the list
            // Then the next panel is display in front
            if (index < panel_list.Count - 1) panel_list[++index].BringToFront();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // If the index is greater than 0
            // Then the previous panel is display in front
            if (index > 0) panel_list[--index].BringToFront();

        }
    }
}
