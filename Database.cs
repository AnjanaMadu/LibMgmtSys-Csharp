using System.Data.SQLite;

namespace MyApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
    }

    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    internal class IssueRecord
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public string DateIssued { get; set; }
        public string DateReturned { get; set; }
    }

    internal class Database
    {
        private SQLiteConnection sqlite;

        public Database(string filename)
        {
            sqlite = new SQLiteConnection($"Data Source={filename};Version=3;");
            sqlite.Open();

            string query = "CREATE TABLE IF NOT EXISTS Students (Id INTEGER PRIMARY KEY, Name TEXT, Grade TEXT)";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS Books (Id INTEGER PRIMARY KEY, Title TEXT, Author TEXT)";
            command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS IssuedBooks (Id INTEGER PRIMARY KEY, StudentId INTEGER, BookId INTEGER, DateIssued TEXT, DateReturned TEXT)";
            command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();

            // Insert some sample data
            // query = "INSERT INTO Students (Name, Grade) VALUES ('John', '10'); INSERT INTO Students (Name, Grade) VALUES ('Jane', '11'); INSERT INTO Students (Name, Grade) VALUES ('Jack', '12')";
            // command = new SQLiteCommand(query, sqlite);
            // command.ExecuteNonQuery();

            // query = "INSERT INTO Books (Title, Author) VALUES ('The Great Gatsby', 'F. Scott Fitzgerald'); INSERT INTO Books (Title, Author) VALUES ('To Kill a Mockingbird', 'Harper Lee'); INSERT INTO Books (Title, Author) VALUES ('The Catcher in the Rye', 'J. D. Salinger')";
            // command = new SQLiteCommand(query, sqlite);
            // command.ExecuteNonQuery();
        }

        public void AddStudent(Student student)
        {
            string query = $"INSERT INTO Students (Name, Grade) VALUES ('{student.Name}', '{student.Grade}')";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public void AddBook(Book book)
        {
            string query = $"INSERT INTO Books (Title, Author) VALUES ('{book.Title}', '{book.Author}')";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public List<Student> FindStudents(string name, int id = -1)
        {
            List<Student> students = new List<Student>();
            string query;
            if (id == -1)
            {
                query = $"SELECT * FROM Students WHERE Name LIKE '%{name}%'";
            }
            else
            {
                query = $"SELECT * FROM Students WHERE Id = {id}";
            }
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Grade = reader.GetString(2)
                });
            }
            return students;
        }

        public List<Book> FindBooks(string title, int id = -1)
        {
            List<Book> books = new List<Book>();
            string query;
            if (id == -1)
            {
                query = $"SELECT * FROM Books WHERE Title LIKE '%{title}%'";
            }
            else
            {
                query = $"SELECT * FROM Books WHERE Id = {id}";
            }
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2)
                });
            }
            return books;
        }

        public void RemoveStudent(int id)
        {
            string query = $"DELETE FROM Students WHERE Id = {id}";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public void RemoveBook(int id)
        {
            string query = $"DELETE FROM Books WHERE Id = {id}";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public void IssueBook(int studentId, int bookId, string dateIssued)
        {
            string query = $"INSERT INTO IssuedBooks (StudentId, BookId, DateIssued, DateReturned) VALUES ({studentId}, {bookId}, '{dateIssued}', 'NULL')";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public void ReturnBook(int studentId, int bookId, string dateReturned)
        {
            string query = $"UPDATE IssuedBooks SET DateReturned = '{dateReturned}' WHERE StudentId = {studentId} AND BookId = {bookId}";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            command.ExecuteNonQuery();
        }

        public List<IssueRecord> NotReturnedBooks()
        {
            List<IssueRecord> records = new List<IssueRecord>();
            string query = $"SELECT * FROM IssuedBooks WHERE DateReturned = 'NULL'";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                records.Add(new IssueRecord
                {
                    Id = reader.GetInt32(0),
                    StudentId = reader.GetInt32(1),
                    BookId = reader.GetInt32(2),
                    DateIssued = reader.GetString(3),
                    DateReturned = reader.GetString(4)
                });
            }
            MessageBox.Show(records.Count.ToString());
            return records;
        }

        public int TotalBooks()
        {
            string query = $"SELECT COUNT(*) FROM Books";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader.GetInt32(0);
        }

        public int TotalStudents()
        {
            string query = $"SELECT COUNT(*) FROM Students";
            SQLiteCommand command = new SQLiteCommand(query, sqlite);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader.GetInt32(0);
        }

        public void Close()
        {
            sqlite.Close();
        }
    }
}
