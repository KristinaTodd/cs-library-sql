using System;
using System.Collections.Generic;
using cs_library_sql.Models;
using cs_library_sql.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cs_library_sql.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BooksController : ControllerBase
  {
    private readonly BooksService _bs;
    public BooksController(BooksService bs)
    {
      _bs = bs;
    }
  }

}