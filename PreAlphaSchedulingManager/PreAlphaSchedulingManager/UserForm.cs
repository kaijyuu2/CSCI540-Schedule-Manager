using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class UserForm : Form
    {
        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            EmployeeAvailabilitySubmissionGridview.ColumnCount = 4;
            EmployeeAvailabilitySubmissionGridview.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            EmployeeAvailabilitySubmissionGridview.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            EmployeeAvailabilitySubmissionGridview.Columns[0].Name = "Recipe";
            EmployeeAvailabilitySubmissionGridview.Columns[1].Name = "Category";
            EmployeeAvailabilitySubmissionGridview.Columns[2].Name = "Main Ingredients";
            EmployeeAvailabilitySubmissionGridview.Columns[3].Name = "Rating";

            // Populate the rows.
            string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef",
           "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert",
           "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish",
           "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad",
           "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert",
           "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer",
           "black beans, sour cream", "***" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            foreach (string[] rowArray in rows)
            {
                EmployeeAvailabilitySubmissionGridview.Rows.Add(rowArray);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // Resize the height of the column headers. 
            EmployeeAvailabilitySubmissionGridview.AutoResizeColumnHeadersHeight();

            // Resize all the row heights to fit the contents of all non-header cells.
            EmployeeAvailabilitySubmissionGridview.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void InitializeContextMenu()
        {
            // Create the menu item.
            ToolStripMenuItem getRecipe = new ToolStripMenuItem("Search for recipe", null,
                new System.EventHandler(ShortcutMenuClick));

            // Add the menu item to the shortcut menu.
            ContextMenuStrip recipeMenu = new ContextMenuStrip();
            recipeMenu.Items.Add(getRecipe);

            // Set the shortcut menu for the first column.
            EmployeeAvailabilitySubmissionGridview.Columns[0].ContextMenuStrip = recipeMenu;
            EmployeeAvailabilitySubmissionGridview.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);
        }

        private DataGridViewCell clickedCell;

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // If the user right-clicks a cell, store it for use by the shortcut menu.
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = EmployeeAvailabilitySubmissionGridview.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    clickedCell =
                        EmployeeAvailabilitySubmissionGridview.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                }
            }
        }

        private void ShortcutMenuClick(object sender, System.EventArgs e)
        {
            if (clickedCell != null)
            {
                //Retrieve the recipe name.
                string recipeName = (string)clickedCell.Value;

                //Search for the recipe.
                System.Diagnostics.Process.Start(
                    "http://search.msn.com/results.aspx?q=" + recipeName);
                //null);
            }
        }

        public UserForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
