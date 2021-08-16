using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace bucksharp
{
	public partial class Form1 : Form
	{
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlConnection con=new SqlConnection();
        SqlCommand com=new SqlCommand();
        private static readonly HttpClient client = new HttpClient();

        public Form1()
		{
			InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            getLabelsValue();
        }

        private void getLabelsValue()
        {
            String connectionString = "Data Source=PC-MEDKHGUEN;Initial Catalog=bucksharp;Integrated Security=True";
            String InsSelectCommand = "select sum(amount) from entry where type='IN'";
            String OutSselectCommand = "select sum(amount) from entry where type='OUT'";
            con = new SqlConnection(connectionString);
            com = new SqlCommand(InsSelectCommand, con);
            int ins = 0;
            int outs = 0;
            int tt = 0;
            try
            {
                con.Open();
                ins = (int)com.ExecuteScalar();
                com = new SqlCommand(OutSselectCommand, con);
                outs = (int)com.ExecuteScalar();
                tt = ins - outs;
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            label1.Text = ins.ToString();
            label2.Text = outs.ToString();
            label3.Text = tt.ToString();
            List<string> x = new List<string>();
            List<int> y = new List<int>();

            x.Add("IN");
            x.Add("OUT");
            y.Add(ins);
            y.Add(outs);
           chart1.Series[0].Points.DataBindXY(x,y);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucksharpDataSet4.currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.bucksharpDataSet4.currency);
            // TODO: This line of code loads data into the 'bucksharpDataSet4.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter2.Fill(this.bucksharpDataSet4.Entry);
            // TODO: This line of code loads data into the 'bucksharpDataSet4.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.bucksharpDataSet4.Category);
            // TODO: This line of code loads data into the 'bucksharpDataSet3.Entry' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bucksharpDataSet2.Entry' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel6.Visible =true;
            panel2.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;
            this.entryTableAdapter2.Fill(this.bucksharpDataSet4.Entry);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel2.Visible = false;
            panel7.Visible = true;
            panel5.Visible = true;
            panel8.Visible = false;

        }  
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = !panel5.Visible;
            if (panel5.Visible)
            {
                button3.Text = "View Entries";
            }
            else
            {
                button3.Text = "View Categories";

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            string title = titleInput.Text;
            string description = descriptionInput.Text;
            if (title == null || title.Length == 0)
            {
                MessageBox.Show("Title is required");
                return;
            }
            if (description == null || description.Length == 0)
            {
                MessageBox.Show("Description is required");
                return;
            }
            int amount = 0;
            if (amountInput.Text == null || amountInput.Text.Length == 0 || !int.TryParse(amountInput.Text, out amount))
            {
                MessageBox.Show("Amount is required and it has to be a number");
                return;
            }
           
            int category_id = (int)categoryInput.SelectedValue;
            if (typeInput.SelectedItem == null)
            {
                MessageBox.Show("Type is required");
                return;
            }
            string type = typeInput.SelectedItem.ToString();
    
            String connectionString = "Data Source=PC-MEDKHGUEN;Initial Catalog=bucksharp;Integrated Security=True";
            String InsSelectCommand = "insert into entry (title, description, amount,date,type,category_id) values(@title,@description,@amount,@date,@type,@category_id)";

            con = new SqlConnection(connectionString);
            com = new SqlCommand(InsSelectCommand, con);
            try
            {
                com.Parameters.Add(new SqlParameter("title",title));
                com.Parameters.Add(new SqlParameter("description", description));
                com.Parameters.Add(new SqlParameter("amount", amount));
                com.Parameters.Add(new SqlParameter("date", dateInput.Value));
                com.Parameters.Add(new SqlParameter("category_id",category_id));
                com.Parameters.Add(new SqlParameter("type",type));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                this.entryTableAdapter2.Fill(this.bucksharpDataSet4.Entry);
                this.getLabelsValue();
                MessageBox.Show("Entry created");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;
            panel8.Visible = false;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;
            panel5.Visible = false;
            panel8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = catnameInput.Text;
            if (name == null || name.Length == 0)
            {
                MessageBox.Show("name is required");
                return;
            }
        
            if (catcolorInput.SelectedItem == null)
            {
                MessageBox.Show("color is required");
                return;
            }
            string color = catcolorInput.SelectedItem.ToString();
            String connectionString = "Data Source=PC-MEDKHGUEN;Initial Catalog=bucksharp;Integrated Security=True";
            String InsSelectCommand = "insert into category (name, color) values(@name,@color)";

            con = new SqlConnection(connectionString);
            com = new SqlCommand(InsSelectCommand, con);
            try
            {
                com.Parameters.Add(new SqlParameter("name",name));
                com.Parameters.Add(new SqlParameter("color",color));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                this.categoryTableAdapter.Fill(this.bucksharpDataSet4.Category);
                this.getLabelsValue();
                MessageBox.Show("Category created");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel8.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void currencyConvert_Click(object sender, EventArgs e)
        {
            float amount = 0;
            if (currencyAmount.Text == null || currencyAmount.Text.Length == 0 || !float.TryParse(currencyAmount.Text, out amount))
            {
                MessageBox.Show("Amount is required and it has to be a number");
                return;
            }

            if (currencyTo.SelectedItem == null)
            {
                MessageBox.Show("currencyTo is required");
                return;
            }
            if (currencyFrom.SelectedItem == null)
            {
                MessageBox.Show("currencyFrom is required");
                return;
            }
            this.convertApi(currencyFrom.SelectedValue.ToString(), currencyTo.SelectedValue.ToString(), amount);
        }
        private  async  void convertApi(string from,string to,float amount)
        {
            try
            {
                var stringTask = client.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + from + "/" + to + ".json");
                currencyConvert.Text = "Converting ....";
                 var msg = await stringTask;
                currencyConvert.Text = "Convert";

                JObject json = JObject.Parse(msg);
                float toVal = float.Parse(json.GetValue(to).ToString());
                Console.Write(toVal);
                Console.Write(msg);
                if (toVal != 0)
                {
                    float res = toVal * amount;
                    currencyReult.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("An error has accured please try again later");
                }
            }catch(Exception e)
            {
                MessageBox.Show("An error has accured please try again later "+ e.Message);

            }

        }

        private void currencyBack_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;
            panel8.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
