using System.ComponentModel;
using System.Windows.Forms;

namespace Crypto_Test
{
    public partial class ControlTextBox : TextBox
    {
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        public ControlTextBox()
        {
            this.AutoSize = false;
        }
    }
}
