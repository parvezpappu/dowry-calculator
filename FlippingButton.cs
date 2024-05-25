////button.Location = new Point(50, buttonTop + i * (buttonHeight + gap));


//namespace WinFormsApp1
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            InitializeCustomComponents();
//            this.ClientSize = new Size(850, 700); // Set initial size
//        }

//        private void InitializeCustomComponents()
//        {
//            this.Text = "Joutuk Koto!";


//            // Set form background color to dark blue
//            this.BackColor = Color.FromArgb(18, 32, 47); // Dark Blue

//            // Add a label with the welcome text
//            Label welcomeLabel = new Label();
//            welcomeLabel.Text = "Welcome to Joutuk Koto!?";

//            //Color.FromArgb(18, 32, 47)
//            welcomeLabel.ForeColor = Color.FromArgb(153, 170, 181); // Lighter shade of the background color
//            welcomeLabel.BackColor = Color.Transparent;
//            welcomeLabel.Font = new Font("Arial", 16, FontStyle.Bold);
//            welcomeLabel.AutoSize = true;
//            welcomeLabel.Location = new Point((this.ClientSize.Width - welcomeLabel.Width) / 2, 50);
//            this.Controls.Add(welcomeLabel);

//            // Define the button texts
//            string[] buttonNames = { "Name", "Current Semester", "CGPA", "Academic Scholarship", "District" };
//            int buttonTop = welcomeLabel.Bottom + 40; // Start below the welcome label
//            int buttonHeight = 40;
//            int gap = 20; // Gap between buttons

//            // Create and add the buttons
//            for (int i = 0; i < buttonNames.Length; i++)
//            {
//                CircularButton button = new CircularButton();
//                button.Text = buttonNames[i];
//                button.ForeColor = Color.White;
//                button.BackColor = Color.DarkGreen;


//                // Slightly lighter dark blue
//                button.Font = new Font("Arial", 12, FontStyle.Regular);
//                button.Size = new Size(200, buttonHeight);
//                button.Location = new Point(50, buttonTop + i * (buttonHeight + gap));
//                button.MouseEnter += (sender, e) => FlipButtonText(button);
//                button.MouseLeave += (sender, e) => FlipButtonText(button);
//                this.Controls.Add(button);
//            }
//        }

//        private void FlipButtonText(Button button)
//        {
//            button.Text = new string(button.Text.Reverse().ToArray());
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            // Additional initialization if needed
//        }


//    }
//}
