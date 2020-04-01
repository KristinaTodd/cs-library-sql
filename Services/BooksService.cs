using System;
using System.Collections.Generic;
using cs_library_sql.Models;
using cs_library_sql.Repositories;

namespace cs_library_sql.Services
{
  public class BooksService
  {
    private readonly BooksService _repo;
    public BooksService(BooksRepository repo)
    {
      _repo = repo;
    }

  }
}