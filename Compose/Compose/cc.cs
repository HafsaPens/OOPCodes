using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compose
{
    public partial class cc : Component
    {
        public cc()
        {
            InitializeComponent();
        }

        public cc(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
