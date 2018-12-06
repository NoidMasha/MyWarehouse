namespace MyUserManagement.MyCalculator
{
    class MyButton : System.Windows.Forms.Button
    {
        public MyButton() : base()
        {

        }
        public MyButton(Calculator MyCalculatorPointer) : base()
        {
            this.Click += new System.EventHandler(OnButtonClick);
            myCalculatorPointer = MyCalculatorPointer;
        }
        //button
        private static string buttonText;
        public static string ButtonText
        {
            get
            {
                return buttonText;
            }
        }

        public Calculator myCalculatorPointer;
        private void OnButtonClick(object sender, System.EventArgs e)
        {
            MyButton button = (MyButton)sender;
            buttonText = button.Text;
            myCalculatorPointer.UpdateOnClick();
        }

    }
}
