using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Api.Controllers.Common;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController:ControllerBase
{ }