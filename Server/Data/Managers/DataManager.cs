using Data.Context;
using Library.Entities;
using Library.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class DataManager<TModel> : IDisposable where TModel : Model
    {
        // Local Fields
        private DataContext Context;

        public DataManager()
        {
            
        }

        // [HttpGet]
        public virtual async Task<KeyValuePair<DataResult, IEnumerable<TModel>>> GetModels(Expression<Func<TModel, bool>> predicate)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    IEnumerable<TModel> result = await this.Context.Set<TModel>().Where(predicate).ToListAsync();

                    if (result.Count() > 0 && result != null) { return new KeyValuePair<DataResult, IEnumerable<TModel>>(DataResult.ModelExists, result); }
                    return new KeyValuePair<DataResult, IEnumerable<TModel>>(DataResult.ModelNotFound, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, IEnumerable<TModel>>(DataResult.Failure, null); }
        }
        // [HttpGet]
        public virtual async Task<KeyValuePair<DataResult, TModel>> GetModel(Expression<Func<TModel, bool>> predicate)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    TModel result = await this.Context.Set<TModel>().FirstOrDefaultAsync(predicate);

                    if (result != null) { return new KeyValuePair<DataResult, TModel>(DataResult.ModelExists, result); }
                    return new KeyValuePair<DataResult, TModel>(DataResult.ModelNotFound, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, TModel>(DataResult.Failure, null); }
        }
        // [HttpPost]
        public virtual async Task<KeyValuePair<DataResult, TModel>> CreateModel(TModel instance)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    TModel result = this.Context.Set<TModel>().Add(instance);
                    await this.Context.SaveChangesAsync();
                    if (result != null) { return new KeyValuePair<DataResult, TModel>(DataResult.Success, result); }
                    return new KeyValuePair<DataResult, TModel>(DataResult.ModelNotFound, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, TModel>(DataResult.Failure, null); }

        }
        // [HttpPut]
        public virtual async Task<KeyValuePair<DataResult, TModel>> UpdateModel(TModel instance, Expression<Func<TModel, bool>> predicate)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    TModel result = await this.Context.Set<TModel>().FirstOrDefaultAsync(predicate);
                    this.Context.Entry(instance).CurrentValues.SetValues(instance);
                    TModel update = await this.Context.Set<TModel>().FirstOrDefaultAsync(predicate);
                    await this.Context.SaveChangesAsync();

                    if (result != null) { return new KeyValuePair<DataResult, TModel>(DataResult.Success, result); }
                    return new KeyValuePair<DataResult, TModel>(DataResult.ModelNotFound, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, TModel>(DataResult.Failure, null); }
        }
        // [HttpGet]
        public virtual async Task<KeyValuePair<DataResult, TModel>> DeleteModel(TModel instance, Expression<Func<TModel, bool>> predicate)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    if (this.Context.Set<TModel>().Remove(instance) != null)
                    {
                        await this.Context.SaveChangesAsync();
                        return new KeyValuePair<DataResult, TModel>(DataResult.ModelExists, instance);
                    }
                    return new KeyValuePair<DataResult, TModel>(DataResult.ModelNotFound, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, TModel>(DataResult.Failure, null); }
        }

        public virtual async Task<KeyValuePair<DataResult, TModel>> CheckModel(TModel instance, Expression<Func<TModel, bool>> predicate)
        {
            try
            {
                using (this.Context = new DataContext())
                {
                    TModel result = await this.Context.Set<TModel>().FirstOrDefaultAsync(predicate);

                    if (result != null) { return new KeyValuePair<DataResult, TModel>(DataResult.Success, result); }
                    return new KeyValuePair<DataResult, TModel>(DataResult.Failure, null);
                }
            }
            catch (Exception) { return new KeyValuePair<DataResult, TModel>(DataResult.ModelNotFound, null); }

        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }
    }
}
