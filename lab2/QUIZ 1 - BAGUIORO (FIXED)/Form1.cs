namespace QUIZ_1___BAGUIORO__FIXED_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Student 1
        private void btnShow1_Click(object sender, EventArgs e)
        {
            double gpa1;
            double c1, c2, c3, sumGrades, items = 100, Gradec1, Gradec2, Gradec3;

            c1 = double.Parse(txtStudent1Course1.Text);
            c2 = double.Parse(txtStudent1Course2.Text);
            c3 = double.Parse(txtStudent1Course3.Text);

            Gradec1 = ((c1 / items) * 85 + 15);
            Gradec2 = (c2 / items) * 85 + 15;
            Gradec3 = (c3 / items) * 85 + 15;
            sumGrades = Gradec1 + Gradec2 + Gradec3;
            gpa1 = (sumGrades / 300);

            lblSTD1Display.Text = $"Name:  {txtStudentName1.Text}";
            lblProgramDisplay1.Text = $"Program: {txtStudentProgram1.Text}";
            lblC1Computed1.Text = $"Course #1: {(Gradec1):F2} ";
            lblC2Computed1.Text = $"Course #2: {(Gradec2):F2} ";
            lblC3Computed1.Text = $"Course #3: {(Gradec3):F2} ";
            txtStudentGrade1.Text = $"{(gpa1):F2}";
        }
        //Student 2
        private void btnShow2_Click(object sender, EventArgs e)
        {
            double gpa2;
            double c1, c2, c3, sumGrades, items = 100, Gradec1, Gradec2, Gradec3;

            c1 = double.Parse(txtStudent2Course1.Text);
            c2 = double.Parse(txtStudent2Course2.Text);
            c3 = double.Parse(txtStudent2Course3.Text);

            Gradec1 = ((c1 / items) * 85 + 15);
            Gradec2 = (c2 / items) * 85 + 15;
            Gradec3 = (c3 / items) * 85 + 15;
            sumGrades = Gradec1 + Gradec2 + Gradec3;
            gpa2 = (sumGrades / 300);

            lblSTD2Display.Text = $"Name:  {txtStudentName2.Text}";
            lblProgramDisplay2.Text = $"Program: {txtStudentProgram2.Text}";
            lblC1Computed2.Text = $"Course #1: {(Gradec1):F2} ";
            lblC2Computed2.Text = $"Course #2: {(Gradec2):F2} ";
            lblC3Computed2.Text = $"Course #3: {(Gradec3):F2} ";
            txtStudentGrade2.Text = $"{(gpa2):F2}";
        }

        //Student 3
        private void btnShow3_Click(object sender, EventArgs e)
        {
            double gpa3;
            double c1, c2, c3, sumGrades, items = 100, Gradec1, Gradec2, Gradec3;

            c1 = double.Parse(txtStudent3Course1.Text);
            c2 = double.Parse(txtStudent3Course2.Text);
            c3 = double.Parse(txtStudent3Course3.Text);

            Gradec1 = ((c1 / items) * 85 + 15);
            Gradec2 = (c2 / items) * 85 + 15;
            Gradec3 = (c3 / items) * 85 + 15;
            sumGrades = Gradec1 + Gradec2 + Gradec3;
            gpa3 = (sumGrades / 300);

            lblSTD3Display.Text = $"Name:  {txtStudentName3.Text}";
            lblProgramDisplay3.Text = $"Program: {txtStudentProgram3.Text}";
            lblC1Computed3.Text = $"Course #1: {(Gradec1):F2} ";
            lblC2Computed3.Text = $"Course #2: {(Gradec2):F2} ";
            lblC3Computed3.Text = $"Course #3: {(Gradec3):F2} ";
            txtStudentGrade3.Text = $"{(gpa3):F2}";
        }

        private void btnComputeAvg_Click(object sender, EventArgs e)
        {
            lblAverageGpa.Text = $"Average GPA of Students: {((double.Parse(txtStudentGrade1.Text) + double.Parse(txtStudentGrade2.Text) + double.Parse(txtStudentGrade3.Text)) / 3):F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Student 1
            txtStudentName1.Clear();
            txtStudentProgram1.Clear();
            txtStudent1Course1.Clear();
            txtStudent1Course2.Clear();
            txtStudent1Course3.Clear();
            txtStudentGrade1.Clear();

            lblSTD1Display.Text = string.Empty;
            lblProgramDisplay1.Text = string.Empty;
            lblC1Computed1.Text = string.Empty;
            lblC2Computed1.Text = string.Empty;
            lblC3Computed1.Text = string.Empty;

            // Student 2
            txtStudentName2.Clear();
            txtStudentProgram2.Clear();
            txtStudent2Course1.Clear();
            txtStudent2Course2.Clear();
            txtStudent2Course3.Clear();
            txtStudentGrade2.Clear();

            lblSTD2Display.Text = string.Empty;
            lblProgramDisplay2.Text = string.Empty;
            lblC1Computed2.Text = string.Empty;
            lblC2Computed2.Text = string.Empty;
            lblC3Computed2.Text = string.Empty;

            // Student 3
            txtStudentName3.Clear();
            txtStudentProgram3.Clear();
            txtStudent3Course1.Clear();
            txtStudent3Course2.Clear();
            txtStudent3Course3.Clear();
            txtStudentGrade3.Clear();

            lblSTD3Display.Text = string.Empty;
            lblProgramDisplay3.Text = string.Empty;
            lblC1Computed3.Text = string.Empty;
            lblC2Computed3.Text = string.Empty;
            lblC3Computed3.Text = string.Empty;

            // Average
            lblAverageGpa.Text = string.Empty;
        }
    }
}
