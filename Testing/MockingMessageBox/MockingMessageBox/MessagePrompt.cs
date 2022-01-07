using System.Windows.Forms;

namespace MockingMessageBox
{
    public class MessagePrompt : IMessagePrompt
    {
        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options, displayHelpButton);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
            => MessageBox.Show(owner, text, caption, buttons);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
            => MessageBox.Show(owner, text, caption, buttons, icon);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options);

        public DialogResult Show(string text)
            => MessageBox.Show(text);

        public DialogResult Show(string text, string caption)
            => MessageBox.Show(text, caption);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
            => MessageBox.Show(text, caption, buttons);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
            => MessageBox.Show(text, caption, buttons, icon);

        public DialogResult Show(IWin32Window owner, string text, string caption)
            => MessageBox.Show(owner, text, caption);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)

            => MessageBox.Show(text, caption, buttons, icon, defaultButton);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator, param);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator, param);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath, keyword);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, keyword);

        public DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath)
            => MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options, helpFilePath);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath);

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
            => MessageBox.Show(text, caption, buttons, icon, defaultButton, options);

        public DialogResult Show(IWin32Window owner, string text)
            => MessageBox.Show(owner, text);
    }
}
