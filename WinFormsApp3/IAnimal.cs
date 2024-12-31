using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    /// <summary>
    /// Loài động vật tùy ý
    /// </summary>
    internal interface IAnimal
    {
        // đi sang phải
        void MoveRight();

        // đi sang trái
        void MoveLeft();

        // đi lên
        void MoveUp();

        // đi xuống
        void MoveDown();
    }
}
