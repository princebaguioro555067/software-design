using System.Security.Cryptography.X509Certificates;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }
        public class Ebook : Book
        {
            public int DOI { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - DOI: {DOI}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }


        //Task 2
        private void btnProcessBooks_Click(object sender, EventArgs e)
        {
            //Step 1
            Book[] library = new Book[]
            {
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "C# Programming", Author = "Jane Smith", DOI = 123456 },
                new Textbook { Title = "Mathematics 101", Author = "Dr. Math", Subject = "Mathematics" },
                new Audiobook { Title = "The Art of War", Author = "Sun Tzu", Duration = 120 }
            };

            listBoxBooks.Items.Clear();
            //Step 2
            foreach (var book in library)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        //Task 3
        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Subject: {Subject}";
            }
        }

        public class Audiobook : Book
        {
            public int Duration { get; set; } // Duration in minutes
            public override string GetInfo()
            {
                return $"{Title} - Duration: {Duration} mins";
            }
        }

        private void btnTextbook_Click(object sender, EventArgs e)
        {
            Book[] Textbooks = new Book[]
            {
                new Textbook { Title = "Mathematics 101", Author = "Dr. Math", Subject = "Mathematics" },
                new Textbook { Title = "Physics 101", Author = "Dr. Physics", Subject = "Physics" },
                new Textbook { Title = "Chemistry 101", Author = "Dr. Chemistry", Subject = "Chemistry" }
            };

            listBoxBooks.Items.Clear();

            foreach (var book in Textbooks)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnAudiobook_Click(object sender, EventArgs e)
        {
            Book[] Audiobooks = new Book[]
            {
                new Audiobook { Title = "The Art of War", Author = "Sun Tzu", Duration = 120 },
                new Audiobook { Title = "1984", Author = "George Orwell", Duration = 180 },
                new Audiobook { Title = "To Kill a Mockingbird", Author = "Harper Lee", Duration = 150 }
            };

            listBoxBooks.Items.Clear();

            foreach (var book in Audiobooks)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }

        }
    }
}