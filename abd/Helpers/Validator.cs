namespace Student.AO.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string name)
        {
            bool validanUnos = true;
            if (kontrola is Guna.UI2.WinForms.Guna2PictureBox && (kontrola as Guna.UI2.WinForms.Guna2PictureBox).Image == null)
                validanUnos = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                validanUnos = false;
            else if (kontrola is Guna.UI2.WinForms.Guna2TextBox && !(kontrola as Guna.UI2.WinForms.Guna2TextBox).Text.Postavljen())
                validanUnos = false;

            if (!validanUnos)
            {
                err.SetError(kontrola, name);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
