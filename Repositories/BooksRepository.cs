using System;
using System.Collections.Generic;
using System.Data;
using cs_library_sql.Models;
using Dapper;

namespace cs_library_sql.Repositories
{
  public class BooksRepository
  {
    private readonly IDbConnection _db;
    public BooksRepository(IDbConnection db)
    {
      _db = db;
    }


  }
}