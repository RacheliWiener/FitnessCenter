using BL;
using BL.BLApi;
using BL.BlServices;
using BL.BO;
using BL.Models;
using fitness_center;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{

    IClientBL blClient;
    public ClientController(BlManager bl)
    {

        this.blClient = bl.client;
    }

    #region Get
    [HttpGet]
    public List<BLReturnClient> GetClient() => blClient.Clients();
    [HttpGet("id/{id}")]
    public BLsimpleClient GetClientById(string id) => blClient.GetClientById(id);

    [HttpGet("{nameOfTrining}")]
    public List<BLschedule> GetAllTimeTrining(string nameOfTrining)
    {
        List<BLschedule> list = blClient.GetAllTimeTriningBL(nameOfTrining);
        if (list == null)
        {
            return null;
        }
        return list;
    }
    #endregion

    #region Post
    [HttpPost]
    public BLsimpleClient Add(BLsimpleClient client) =>blClient.AddClientBL(client);
    #endregion

    #region Delete
    [HttpDelete]
    public BLsimpleClient delete(BLsimpleClient client)=>blClient.DeleteClientBL(client);
    #endregion

}










