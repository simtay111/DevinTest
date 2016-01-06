namespace DevinTest
{
    public class ScopingParent
    {
        public void MainMethod()
        {
            var secondary = new SecondaryClass();

            //secondary.myPublicField

            secondary.PublicMethod();

        }

    }

    public class SecondaryClass
    {
        public string myPublicField;
        private string myPrivateField;

        public void PublicMethod()
        {

        }
        private void PrivateMethod()
        {

        }
    }
}