using System.Data;

namespace MyApp1
{
    public partial class LibraryApp : Form
    {
        private Database db;
        public LibraryApp()
        {
            InitializeComponent();
            db = new Database("library.db");
            initReports();
        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {
            string stuName = addStuN.Text;
            string stuGrade = addStuG.Text;
            if (stuName != "" && stuGrade != "")
            {
                var stu = new Student();
                stu.Name = stuName;
                stu.Grade = stuGrade;
                db.AddStudent(stu);
                MessageBox.Show("Student Added");
                addStuN.Clear();
                addStuG.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name and grade");
            }
        }

        private void stuRmBtn_Click(object sender, EventArgs e)
        {
            string stuId = rmStuID.Text;
            if (stuId != "")
            {
                db.RemoveStudent(Convert.ToInt32(stuId));
                MessageBox.Show("Student Removed");
                rmStuID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a student ID");
            }
        }

        private void stuFindBtn_Click(object sender, EventArgs e)
        {
            string stuName = findStuN.Text;
            if (stuName != "")
            {
                List<Student> stuInfo = db.FindStudents(stuName);
                // Show list as a table
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Grade", typeof(string));
                foreach (var stu in stuInfo)
                {
                    table.Rows.Add(stu.Id, stu.Name, stu.Grade);
                }
                dataGridView1.DataSource = table;
                findStuN.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a student name");
            }
        }

        private void addBkbtn_Click(object sender, EventArgs e)
        {
            string bkName = addbkN.Text;
            string bkAuthor = addBkA.Text;
            if (bkName != "" && bkAuthor != "")
            {
                var bk = new Book();
                bk.Title = bkName;
                bk.Author = bkAuthor;
                db.AddBook(bk);
                MessageBox.Show("Book Added");
                addbkN.Clear();
                addBkA.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name, author, and genre");
            }

        }

        private void rnBkBtn_Click(object sender, EventArgs e)
        {
            string bkId = rmBkId.Text;
            if (bkId != "")
            {
                db.RemoveBook(Convert.ToInt32(bkId));
                MessageBox.Show("Book Removed");
                rmBkId.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a book ID");
            }

        }

        private void findBkBtn_Click(object sender, EventArgs e)
        {
            string bkName = findBkN.Text;
            if (bkName != "")
            {
                List<Book> bkInfo = db.FindBooks(bkName);
                // Show list as a table
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Title", typeof(string));
                table.Columns.Add("Author", typeof(string));
                foreach (var bk in bkInfo)
                {
                    table.Rows.Add(bk.Id, bk.Title, bk.Author);
                }
                dataGridView2.DataSource = table;
                findBkN.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a book name");
            }

        }

        private void initReports()
        {
            numBk.Text = db.TotalBooks().ToString();
            numStu.Text = db.TotalStudents().ToString();

            List<IssueRecord> hvntRcv = db.NotReturnedBooks();
            // grab id of books and students to dictionaries
            Dictionary<int, string> bkDict = new Dictionary<int, string>();
            Dictionary<int, string> stuDict = new Dictionary<int, string>();
            foreach (var record in hvntRcv)
            {
                if (!bkDict.ContainsKey(record.BookId))
                {
                    bkDict.Add(record.BookId, db.FindBooks("", record.BookId)[0].Title);
                }
                if (!stuDict.ContainsKey(record.StudentId))
                {
                    stuDict.Add(record.StudentId, db.FindStudents("", record.StudentId)[0].Name);
                }
            }

            // Show list as a table
            DataTable table = new DataTable();
            table.Columns.Add("Book ID", typeof(int));
            table.Columns.Add("Book Title", typeof(string));
            table.Columns.Add("Student ID", typeof(int));
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("Date Issued", typeof(string));
            foreach (var record in hvntRcv)
            {
                table.Rows.Add(record.BookId, bkDict[record.BookId], record.StudentId, stuDict[record.StudentId], record.DateIssued);
            }
            hvntRet.DataSource = table;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            initReports();
        }

        private void Issuebtn_Click(object sender, EventArgs e)
        {
            if (issueBkId.Text != "" && IssueStuId.Text != "")
            {
                var BkId = Convert.ToInt32(issueBkId.Text);
                var StuId = Convert.ToInt32(IssueStuId.Text);
                var Issdate = DateTime.Now.ToString("yyyy-MM-dd");
                db.IssueBook(StuId, BkId, Issdate);
                MessageBox.Show("Book Issued");
                issueBkId.Clear();
                IssueStuId.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a book ID and student ID");
            }

        }

        private void RetBtn_Click(object sender, EventArgs e)
        {
            if (retBkId.Text != "" && retStuId.Text != "")
            {
                var BkId = Convert.ToInt32(retBkId.Text);
                var StuId = Convert.ToInt32(retStuId.Text);
                var RetDate = DateTime.Now.ToString("yyyy-MM-dd");
                db.ReturnBook(StuId, BkId, RetDate);
                MessageBox.Show("Book Returned");
                retBkId.Clear();
                retStuId.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a book ID and student ID");
            }
        }
    }
}
