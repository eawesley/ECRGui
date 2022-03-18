using System;
using System.Collections.Generic;
using ECRGui.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ECRGui
{
    class Program
    {
        MongoCRUD db = new MongoCRUD("InfluxECR");

            /*ECRModel exampleChange = new ECRModel
            {
                Id = ObjectId.GenerateNewId(),
                Number = "1045",
                Description = "An example change (changed)",
                Changes = new List<PartChange>
                {
                    new PartChange()
                    {
                        Id = ObjectId.GenerateNewId(),
                        Part = new DrawingModel()
                        {
                            Id = ObjectId.GenerateNewId(),
                            Number = "M1456",
                            Revision = "01",
                            Description = "End Block SS Angled",
                            Date = DateTime.Now
                        },
                        Description = "An example part change"
                    }
                }
            };

            db.InsertRecord("Register", exampleChange);
            
            var testRecord = db.FindRecordByEcrNumber<EcrModel>("Register", "1045");
            testRecord.Changes[0].Part.Description = "A changed part change again!";
            testRecord.Changes.Add(new ChangeModel()
            {
                ChangeId = ObjectId.GenerateNewId()
            });
            db.UpsertRecord("Register", testRecord.EcrId, testRecord);

            Console.ReadLine();*/
    }
}
