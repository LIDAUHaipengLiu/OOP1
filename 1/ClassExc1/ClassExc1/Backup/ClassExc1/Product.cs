using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExc1
{
    public class Product
    {    
       /// <summary>
       /// 商品名称
       /// </summary>
        public string _name;
        /// <summary>
        /// 商品价格
        /// </summary>
        public double _price;
        /// <summary>
        /// 库存数量
        /// </summary>
        public int _shuliang;
        /// <summary>
        /// 商品分类
        /// </summary>
        public string _class;
       
        /// <summary>
        /// 购买商品
        /// </summary>
        /// <param name="s1">购买的数量</param>
        /// <returns></returns>
        public string Buy(int s1)
        {
            string str = "";
            if (_shuliang > 0 && _shuliang > s1)
            {
                _shuliang -= s1;
                str = "我花" + _price.ToString() + "元，购买了" + s1.ToString() + "个" + _name + "还剩下" + _shuliang.ToString() + "个";
            }
            else
            {
                str = "该商品库存不足";
            }
            return str;
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="s1">进货的数量</param>
        public void Jinhuo(int s1)
        {
            _shuliang += s1;
        }
        
     

    }
}
