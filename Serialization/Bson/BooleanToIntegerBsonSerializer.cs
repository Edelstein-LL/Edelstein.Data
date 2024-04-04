using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Edelstein.Data.Serialization.Bson;

public class BooleanToIntegerBsonSerializer : SerializerBase<bool>
{
    public override bool Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    {
        IBsonReader? bsonReader = context.Reader;

        switch (bsonReader.GetCurrentBsonType())
        {
            case BsonType.Int32:
                return Convert.ToBoolean(bsonReader.ReadInt32());
            case BsonType.Boolean:
                return bsonReader.ReadBoolean();
            default:
                throw new BsonSerializationException($"Cannot deserialize BsonType {bsonReader.GetCurrentBsonType()} to a boolean.");
        }
    }

    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, bool value)
    {
        IBsonWriter? bsonWriter = context.Writer;

        bsonWriter.WriteInt32(Convert.ToInt32(value));
    }
}
