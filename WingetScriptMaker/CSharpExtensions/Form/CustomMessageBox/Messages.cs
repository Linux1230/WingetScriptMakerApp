using System.Windows.Forms;

namespace CSharpExtensions.Form.CustomMessageBox
{
    public static class Messages
    {
        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInformation(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestionYesNo(string text)
        {
            DialogResult dialogResult = MessageBox.Show(text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult;
        }

        public static DialogResult ShowQuestionYesNoCancel(string text)
        {
            DialogResult dialogResult = MessageBox.Show(text, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return dialogResult;
        }

        public static DialogResult ShowDialogOk(string text)
        {
            DialogResult dialogResult = MessageBox.Show(text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return dialogResult;
        }

        public static DialogResult ShowDialogOkCancel(string text)
        {
            DialogResult dialogResult = MessageBox.Show(text, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            return dialogResult;
        }
    }
}
