using System;

using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void JSON_Click(object sender, EventArgs e)
        {

        }

        

        private void JSONRead_Click(object sender, EventArgs e)
        {
            try
            {
              
                Student student1 = new Student();

                FileStream fs = new FileStream(@"D:\StudentJSON .json", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                student1 = (Student)binaryFormatter.Deserialize(fs);
              

                BinaryReader br = new BinaryReader(fs);
                StudentID.Text = br.ReadInt32().ToString();
                StudentTxt.Text = br.ReadString();
                PercentageTxt.Text = student1.StudentId.ToString();
                NameTxt.Text = student1.StudentName;
                PercentageTxt.Text = student1.StudentPercentage.ToString();

                PercentageTxt.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void StudentID_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void JSONWrite_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\StudentDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(StudentTxt.Text));
                bw.Write(NameTxt.Text);
                bw.Write(Convert.ToDouble(PercentageTxt.Text));
                bw.Write(dept.Text);
                Student student1 = new Student();
                student1.StudentId = Convert.ToInt32(StudentID.Text);
                student1.StudentName = NameTxt.Text;
                student1.StudentPercentage = Convert.ToInt32(PercentageTxt.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to Student file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void XMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                
                Student student1 = new Student();

                FileStream fs = new FileStream(@"D:\Studentxml .xml", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                student1 = (Student)binaryFormatter.Deserialize(fs);
          

                BinaryReader br = new BinaryReader(fs);
                StudentID.Text = br.ReadInt32().ToString();
                StudentTxt.Text = br.ReadString();
                PercentageTxt.Text = student1.StudentId.ToString();
                NameTxt.Text = student1.StudentName;
                PercentageTxt.Text = student1.StudentPercentage.ToString();

                PercentageTxt.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentDoc\Student.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(StudentTxt.Text));
                bw.Write(NameTxt.Text);
                bw.Write(Convert.ToDouble(PercentageTxt.Text));
                Student student1 = new Student();
                student1.StudentId = Convert.ToInt32(StudentID.Text);
                student1.StudentName = NameTxt.Text;
                student1.StudentPercentage = Convert.ToInt32(PercentageTxt.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to Student file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                
             

                FileStream fs = new FileStream(@"D:\StudentDoc\Student.dat", FileMode.Open, FileAccess.Read);
                Student student1 = new Student();


                BinaryFormatter binaryFormatter = new BinaryFormatter();

                student1 = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();





                StudentTxt.Text = student1.StudentId.ToString();
                NameTxt.Text = student1.StudentName;
                PercentageTxt.Text = student1.StudentPercentage.ToString();

                dept.Text = student1.StudentDepartment.ToString();
              
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\StudentDoc\Student.dat", FileMode.Create, FileAccess.Write);
                
                Student student1 =  new Student();
                student1.StudentId = Convert.ToInt32(StudentID.Text);
                student1.StudentName = NameTxt.Text;
                student1.StudentPercentage = Convert.ToInt32(PercentageTxt.Text);
                student1.StudentDepartment = dept.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, student1);
                fs.Close();
                MessageBox.Show("Data saved to Student file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Student student1 = new Student();

                FileStream fs = new FileStream(@"D:\StudentSOAP.soap", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                student1 = (Student)binaryFormatter.Deserialize(fs);
           

                BinaryReader br = new BinaryReader(fs);
                StudentID.Text = br.ReadInt32().ToString();
                NameTxt.Text = br.ReadString();
                PercentageTxt.Text = student1.StudentId.ToString();
                NameTxt.Text = student1.StudentName;
                PercentageTxt.Text = student1.StudentPercentage.ToString();

                PercentageTxt.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SOAPWrite_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\StudentSOAP.soap", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(StudentTxt.Text));
                bw.Write(NameTxt.Text);
                bw.Write(Convert.ToDouble(PercentageTxt.Text));
                Student student1 = new Student();
                student1.StudentId = Convert.ToInt32(StudentID.Text);
                student1.StudentName = NameTxt.Text;
                student1.StudentPercentage = Convert.ToInt32(PercentageTxt.Text);
                student1.StudentDepartment = dept.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to Student file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void StudentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PercentageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dept_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }

        private void StudentPercentage_Click(object sender, EventArgs e)
        {

        }
    }
}
