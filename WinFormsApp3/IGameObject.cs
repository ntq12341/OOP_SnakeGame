using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    /// <summary>
    /// Đối tượng trong 1 game bất kỳ
    /// </summary>
    internal interface IGameObject
    {
        // khởi tạo đối tượng
        void Init(int a);
        // đối tượng ghi điểm
        void Score();
        // đối tượng chết/thua cuộc
        void Dead();
    }
}
