using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint > kısıtlama
    //class: referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()  //burada T ne olabilir diye kısıtladık.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //expression filter yazmamızı sağlar.
        T Get(Expression<Func<T, bool>> filter); //filter vermiyorsa tüm datayı ister.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
