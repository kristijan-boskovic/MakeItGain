using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MakeItGain.MemoryBasedDAL.Tests
{
    public class SyncUnitTest
    {
        //private const string serverUrl = "https://dev.visium.io/";
        //private const string USERNAME = "kristijan.boskovic@tagitinc.com";
        //private const string PASSWORD = "q1w2e3R$";
        //private SyncClient syncClient;

        //public SyncUnitTest()
        //{
        //    Log.Logger = new LoggerConfiguration()
        //        .MinimumLevel.Debug()
        //        .CreateLogger();
        //    LoggerFactory loggerFactory = new LoggerFactory();
        //    string testDbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "visium.db");
        //    VisiumDB db = new VisiumDB(testDbPath);
        //    syncClient = new SyncClient(new UserSession(), new TestUserSessionListener(), HttpLoggingLevel.BODY, db.TagObservationDao, db.SyncHistoryDao, db.PersonDao, db.OrganizationDao,
        //        db.SettingDao, db.TagDao, db.ItemDao, db.LocationDao, loggerFactory, new OrganizationSyncRepository(null, loggerFactory), new ItemSyncRepository(null, null, null, null, null, null, null, null, null, loggerFactory));
        //    Task.Run(() => this.syncClient.TryToLogin(serverUrl, USERNAME, PASSWORD)).Wait();
        //}

        //[Trait("Category", "Health")]
        //[Fact]
        //public async Task CheckConnection_ReturnsConnectionResponse()
        //{
        //    // Act
        //    var connectionResponse = await syncClient.SyncInterface.CheckConnection(new CancellationToken());

        //    // Assert
        //    Assert.True(connectionResponse.IsSuccessStatusCode, "Status code: " + connectionResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Location")]
        //[Fact]
        //public async Task GetLocations_ReturnsLocations()
        //{
        //    // Act
        //    var locationsResponse = await syncClient.SyncInterface.GetLocations(1, 100, null, null);

        //    // Assert
        //    Assert.True(locationsResponse.IsSuccessStatusCode, "Status code: " + locationsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Location")]
        //[Fact]
        //public async Task GetLocationByGuid_ReturnsLocationByGuid()
        //{
        //    // Act
        //    var locationResponse = await syncClient.SyncInterface.GetLocationByGuid("10d30494-c3b8-4f8a-8c1f-7c2c38558b7b");

        //    // Assert
        //    Assert.True(locationResponse.IsSuccessStatusCode, "Status code: " + locationResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task GetItems_ReturnsItems()
        //{
        //    // Act
        //    var itemsResponse = await syncClient.SyncInterface.GetItems(new ItemSearchCriteria(0, 0, null, true, new OrderBy("name", false), null, null, null), new CancellationToken());

        //    // Assert
        //    Assert.True(itemsResponse.IsSuccessStatusCode, "Status code: " + itemsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task GetItemsByIds_ReturnsItemsByIds()
        //{
        //    // Act
        //    var itemsResponse = await syncClient.SyncInterface.GetItemsByIds(new List<string> { "ad741350-d5de-493a-a954-31a37fb1804f", "078a8b6a-3283-42ae-a52e-a4b2d778fe14" });

        //    // Assert
        //    Assert.True(itemsResponse.IsSuccessStatusCode, "Status code: " + itemsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task GetMyItems_ReturnsMyItems()
        //{
        //   // Act
        //   var itemsResponse = await syncClient.SyncInterface.GetMyItems(new ItemSearchCriteria(0, 0, null, true, new OrderBy("name", false), null, null, null), new CancellationToken());

        //    // Assert
        //    Assert.True(itemsResponse.IsSuccessStatusCode, "Status code: " + itemsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task GetItemByGuid_ReturnsItemByGuid()
        //{
        //    // Act
        //    var itemResponse = await syncClient.SyncInterface.GetItemByGuid("ad741350-d5de-493a-a954-31a37fb1804f");

        //    // Assert
        //    Assert.True(itemResponse.IsSuccessStatusCode, "Status code: " + itemResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Manufacturer")]
        //[Fact]
        //public async Task GetManufacturers_ReturnsManufacturers()
        //{
        //    // Act
        //    var manufacturersResponse = await syncClient.SyncInterface.GetManufacturers(1, 100, null, null);

        //    // Assert
        //    Assert.True(manufacturersResponse.IsSuccessStatusCode, "Status code: " + manufacturersResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Manufacturer")]
        //[Fact]
        //public async Task GetManufacturerByGuid_ReturnsManufacturerByGuid()
        //{
        //    // Act
        //    var manufacturerResponse = await syncClient.SyncInterface.GetManufacturerByGuid("147de2d8-ae1b-4a22-a656-10905b07bb14");

        //    // Assert
        //    Assert.True(manufacturerResponse.IsSuccessStatusCode, "Status code: " + manufacturerResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Model")]
        //[Fact]
        //public async Task GetModels_ReturnsModels()
        //{
        //    // Act
        //    var modelsResponse = await syncClient.SyncInterface.GetModels(1, 100, null, null);

        //    // Assert
        //    Assert.True(modelsResponse.IsSuccessStatusCode, "Status code: " + modelsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Model")]
        //[Fact]
        //public async Task GetModelByGuid_ReturnsModelByGuid()
        //{
        //    // Act
        //    var modelResponse = await syncClient.SyncInterface.GetModelByGuid("0147f3e1-6b61-4ea9-a685-1fb451b9e66b");

        //    // Assert
        //    Assert.True(modelResponse.IsSuccessStatusCode, "Status code: " + modelResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Container")]
        //[Fact]
        //public async Task GetContainers_ReturnsContainers()
        //{
        //    // Act
        //    var containersResponse = await syncClient.SyncInterface.GetContainers(new ContainerSearchCriteria(0, 0, null, true, new OrderBy("name", false), null, null, null, null), new CancellationToken());

        //    // Assert
        //    Assert.True(containersResponse.IsSuccessStatusCode, "Status code: " + containersResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Container")]
        //[Fact]
        //public async Task GetContainerByItemGuid_ReturnsContainerByItemGuid()
        //{
        //    // Act
        //    var containerResponse = await syncClient.SyncInterface.GetContainerByItemGuid("d2d87848-5f0e-457b-a61e-1196c39f7c42");

        //    // Assert
        //    Assert.True(containerResponse.IsSuccessStatusCode, "Status code: " + containerResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "ContainerConfig")]
        //[Fact]
        //public async Task GetContainerConfig_ReturnsContainerConfig()
        //{
        //    // Act
        //    var containerConfigResponse = await syncClient.SyncInterface.GetContainerConfig("0b462e9d-6406-4de3-ae65-4afc51c835bf");

        //    // Assert
        //    Assert.True(containerConfigResponse.IsSuccessStatusCode, "Status code: " + containerConfigResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Person")]
        //[Fact]
        //public async Task GetPersons_ReturnsPersons()
        //{
        //    // Act
        //    var personsResponse = await syncClient.SyncInterface.GetPersons(1, 100, null, null);

        //    // Assert
        //    Assert.True(personsResponse.IsSuccessStatusCode, "Status code: " + personsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Person")]
        //[Fact]
        //public async Task GetPersonByGuid_ReturnsPersonByGuid()
        //{
        //    // Act
        //    var personResponse = await syncClient.SyncInterface.GetPersonByGuid("02b70ca9-7bde-4d25-b5d7-f2d6af848d58");

        //    // Assert
        //    Assert.True(personResponse.IsSuccessStatusCode, "Status code: " + personResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task GetEntitiesByEpc_ReturnsEntitiesByEpc()
        //{
        //    // Act
        //    var itemResponse = await syncClient.SyncInterface.GetEntitiesByEpc(new List<string> { "3445925D40000000000005A6" });

        //    // Assert
        //    Assert.True(itemResponse.IsSuccessStatusCode, "Status code: " + itemResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Tag")]
        //[Fact]
        //public async Task GetTags_ReturnsTags()
        //{
        //    // Act
        //    var tagsResponse = await syncClient.SyncInterface.GetTags(1, 100, null, null);

        //    // Assert
        //    Assert.True(tagsResponse.IsSuccessStatusCode, "Status code: " + tagsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Tag")]
        //[Fact]
        //public async Task GetTagByEpc_ReturnsTagByEpc()
        //{
        //    // Act
        //    var tagResponse = await syncClient.SyncInterface.GetTagByEpc("3445925D40000000000005A6");

        //    // Assert
        //    Assert.True(tagResponse.IsSuccessStatusCode, "Status code: " + tagResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "ItemClass")]
        //[Fact]
        //public async Task GetItemClasses_ReturnsItemClasses()
        //{
        //    // Act
        //    var itemClassesResponse = await syncClient.SyncInterface.GetItemClasses(1, 100, null, null);

        //    // Assert
        //    Assert.True(itemClassesResponse.IsSuccessStatusCode, "Status code: " + itemClassesResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "ItemClass")]
        //[Fact]
        //public async Task GetItemClassByGuid_ReturnsItemClassByGuid()
        //{
        //    // Act
        //    var itemClassResponse = await syncClient.SyncInterface.GetItemClassByGuid("0646bdb0-546b-49c9-ac91-d720f2a87599");

        //    // Assert
        //    Assert.True(itemClassResponse.IsSuccessStatusCode, "Status code: " + itemClassResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Organization")]
        //[Fact]
        //public async Task GetMyOrganizations_ReturnsMyOrganizations()
        //{
        //    // Act
        //    var organizationsResponse = await syncClient.SyncInterface.GetMyOrganizations();

        //    // Assert
        //    Assert.True(organizationsResponse.IsSuccessStatusCode, "Status code: " + organizationsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Organization")]
        //[Fact]
        //public async Task GetSettings_ReturnsSettings()
        //{
        //    // Act
        //    var settingsResponse = await syncClient.SyncInterface.GetSettings();

        //    // Assert
        //    Assert.True(settingsResponse.IsSuccessStatusCode, "Status code: " + settingsResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task EnrollItem_EnrollsNewItem()
        //{
        //    // Act
        //    var itemCreatedResponse = await syncClient.SyncInterface.EnrollItem(new PostItem("Kiki item", null, null, null, null, "2a06465b-9e3c-46c9-a2f3-97a9c4b05ec3", null, false, null));

        //    // Assert
        //    Assert.True(itemCreatedResponse.IsSuccessStatusCode, "Status code: " + itemCreatedResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Tag")]
        //[Fact]
        //public async Task EnrollTag_EnrollsNewTag()
        //{
        //    // Act
        //    var tagCreatedResponse = await syncClient.SyncInterface.EnrollTag(new PostTag("54448F554000000000096H1" + new Random().Next(0, 1000000), "6a0d6243-b34e-4ef1-b5d8-30acd50c8598", "Item", false)); // use different EPC each time to pass test

        //    // Assert
        //    Assert.True(tagCreatedResponse.IsSuccessStatusCode, "Status code: " + tagCreatedResponse.StatusCode.ToString());

        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task UpdateItem_UpdatesExistingItem()
        //{
        //    // Act
        //    var itemUpdatedResponse = await syncClient.SyncInterface.UpdateItem("0067cc08-e58b-47b4-8d26-1f0654b728d2", new List<PatchOp>());

        //    // Assert
        //    Assert.True(itemUpdatedResponse.IsSuccessStatusCode, "Status code: " + itemUpdatedResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Item")]
        //[Fact]
        //public async Task DecommissionItem_DecommissionsExistingItem()
        //{
        //    // Act
        //    var itemDecommissionedResponse = await syncClient.SyncInterface.DecommissionItem("4406560a-06c1-4629-82ca-ddec68f455e0", "mesage");

        //    // Assert
        //    Assert.True(itemDecommissionedResponse.IsSuccessStatusCode, "Status code: " + itemDecommissionedResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Misc")]
        //[Fact]
        //public async Task PushObservations_PushesPendingObservations()
        //{
        //    // Arrange
        //    var observation = new Observation("100000000000000000000125", "02b70ca9-7bde-4d25-b5d7-f2d6af848d58", DateTime.UtcNow, null, null, null, null, new ObservationsLocation("04c6c770-a11b-461c-856f-1628d5e60e17", null));
        //    var observationList = new List<Observation>();
        //    observationList.Add(observation);
        //    Observations observations = new Observations(observationList, ApiObservationType.INVENTORY);

        //    // Act
        //    var observationsPushedResponse = await syncClient.SyncInterface.PushObservations(observations);

        //    // Assert
        //    Assert.True(observationsPushedResponse.IsSuccessStatusCode, "Status code: " + observationsPushedResponse.StatusCode.ToString());
        //}

        //[Trait("Category", "Misc")]
        //[Fact]
        //public async Task UploadPhoto_UploadsItemPhoto()
        //{
        //    // Act
        //    var stream = File.OpenRead("Item 3 screenshot.jpg");
        //    var pictureUploadedResponse = await syncClient.SyncInterface.UploadPhoto(new StreamPart(stream, "image", "image/jpeg"), "2", "4406560a-06c1-4629-82ca-ddec68f455e0", "1");

        //    // Assert
        //    Assert.True(pictureUploadedResponse.IsSuccessStatusCode, "Status code: " + pictureUploadedResponse.StatusCode.ToString());
        //}
    }
}