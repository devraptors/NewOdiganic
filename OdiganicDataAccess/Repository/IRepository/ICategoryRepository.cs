using OdiganicModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdiganicDataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category category);
    }
}
