

using System;
using System.Collections.ObjectModel;
using System.Data;
using TSD.AccountingSoft.BusinessEntities.Dictionary;
using TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary;
using TSD.AccountingSoft.DataHelpers;

namespace TSD.AccountingSoft.DataAccess.SqlServer.Dictionary
{
    /// <summary>
    /// SqlServerRefTypeDao
    /// </summary>
    public class SqlServerRefTypeDao : IRefTypeDao
    {

        /// <summary>
        ///     Takes the specified department.
        /// </summary>
        /// <param name="refTypeEntity">The department.</param>
        /// <returns></returns>
        private static object[] Take(RefTypeEntity refTypeEntity)
        {
            return new object[]
            {
                //"@RefTypeID", refTypeEntity.RefTypeId,
                //"@DefaultCreditAccountCategoryID", refTypeEntity.DefaultCreditAccountCategoryId,
                //"@DefaultCreditAccountID", refTypeEntity.DefaultCreditAccountId,
                //"@DefaultDebitAccountCategoryID", refTypeEntity.DefaultDebitAccountCategoryId,
                //"@DefaultDebitAccountID", refTypeEntity.DefaultDebitAccountId,
                //"@DefaultTaxAccountCategoryID", refTypeEntity.DefaultTaxAccountCategoryId,
                //"@DefaultTaxAccountID", refTypeEntity.DefaultTaxAccountId
            };
        }


        private static object[] TakeInsert(RefTypeEntity refTypeEntity)
        {
            return new object[]
            {
               "@RefTypeID ",refTypeEntity.RefTypeID,
               "@RefTypeNo ",refTypeEntity.RefTypeNo,
               "@RefTypeCode ",refTypeEntity.RefTypeCode,
               "@RefTypeName ",refTypeEntity.RefTypeName,
               "@RefTypeCaption ",refTypeEntity.RefTypeCaption,
               "@FrmDetail ",refTypeEntity.FrmDetail,
               "@NameSpace ",refTypeEntity.NameSpace,
               "@SystemType ",refTypeEntity.SystemType,
               "@IsEnable ",refTypeEntity.IsEnable,
               "@ViewModel ",refTypeEntity.ViewModel,

            };
        }

        /// <summary>
        /// Gets the reference types.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<RefTypeEntity> GetRefTypes()
        {
            const string procedures = @"uspGet_All_RefType";
            return Db.ReadObser(procedures, true, Make);
        }


        /// <summary>
        /// Gets the reference type Search.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<RefTypeEntity> GetRefTypeSearch()
        {
            const string procedures = @"uspGet_All_RefTypeSearch";
            return Db.ReadObser(procedures, true, Make);
        }


        /// <summary>
        /// Gets the type of the reference.
        /// </summary>
        /// <param name="refTypeId">The reference type identifier.</param>
        /// <returns></returns>
        public RefTypeEntity GetRefType(int refTypeId)
        {
            const string sql = @"uspGet_RefType_ByID";

            object[] parms = { "@RefTypeID", refTypeId };
            return Db.Read(sql, true, Make, parms);
        }
        /// <summary>
        /// Updates the type of the reference.
        /// </summary>
        /// <param name="refTypeEntity">The reference type entity.</param>
        /// <returns></returns>
        public string UpdateRefType(RefTypeEntity refTypeEntity)
        {
            const string sql = @"uspUpdate_RefType";
            return Db.Update(sql, true, TakeInsert(refTypeEntity));
        }
        public string DeleteRefTypeConvert()
        {
            const string sql = @"usp_ConvertAccountDefault";
            object[] parms = { };
            return Db.Delete(sql, true, parms);
        }

        public string InsertReftype(RefTypeEntity refTypeEntity)
        {
            const string sql = @"uspInsert_RefType";
            return Db.Update(sql, true, TakeInsert(refTypeEntity));
        }

        /// <summary>
        /// The make
        /// </summary>
        private static readonly Func<IDataReader, RefTypeEntity> Make = reader => new RefTypeEntity
        {
            RefTypeID = reader["RefTypeID"].AsLong(),
            RefTypeNo = reader["RefTypeNo"].AsInt(),
            RefTypeCode = reader["RefTypeCode"].AsString(),
            RefTypeName = reader["RefTypeName"].AsString(),
            RefTypeCaption = reader["RefTypeCaption"].AsString(),
            FrmDetail = reader["FrmDetail"].AsString(),
            NameSpace = reader["NameSpace"].AsString(),
            SystemType = reader["SystemType"].AsInt(),
            IsEnable = reader["IsEnable"].AsBool(),
            ViewModel = reader["ViewModel"].AsString(),


        };
    }
}
