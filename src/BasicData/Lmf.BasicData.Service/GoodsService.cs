//*******************************
// Create By mengfeng
// Date 2019-10-19 00:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Repository;

namespace Lmf.BasicData.Service
{
    ///<summary>
    /// Table, goods
    ///</summary>
    public class GoodsService
    {
        public IGoodsRepository GoodsRepository { get; }

        public GoodsService(IGoodsRepository goodsRepository)
        {
            GoodsRepository = goodsRepository;
        }

        public int Insert(Goods goods)
        {
            return GoodsRepository.Insert(goods);
        }

        public int DeleteById(int id)
        {
            return GoodsRepository.DeleteById(id);
        }

        public int Update(Goods goods)
        {
            return GoodsRepository.Update(goods);
        }

    }
}

