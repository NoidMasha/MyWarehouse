namespace MyUserManagement.MyCalculator
{
    class MyLabel : System.Windows.Forms.Label
    {
        public MyLabel() : base()
        {

        }

        public string InputText
        {
            set
            {
                if (value != null)
                {
                    int lenght = value.Length;
                    if (!value.Contains("."))
                    {
                        for (int i = 1; i * 3 < lenght; i++)
                        {
                            value = value.Insert(lenght - 3 * i, ",");
                        }
                    }
                    else
                    {
                        int pointIndex = value.IndexOf(".");
                        for (int i = 1; i * 3 < pointIndex; i++)
                        {
                            value = value.Insert(pointIndex - 3 * i, ",");
                        }

                    }
                    Text = value;
                }
            }
        }
    }
}
