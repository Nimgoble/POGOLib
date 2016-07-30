// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos.Map.proto

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

namespace POGOProtos.Map
{
    /// <summary>Holder for reflection information generated from POGOProtos.Map.proto</summary>
    public static partial class POGOProtosMapReflection
    {
        #region Descriptor

        /// <summary>File descriptor for POGOProtos.Map.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static POGOProtosMapReflection()
        {
            var descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "ChRQT0dPUHJvdG9zLk1hcC5wcm90bxIOUE9HT1Byb3Rvcy5NYXAaGVBPR09Q",
                    "cm90b3MuTWFwLkZvcnQucHJvdG8aHFBPR09Qcm90b3MuTWFwLlBva2Vtb24u",
                    "cHJvdG8igQQKB01hcENlbGwSEgoKczJfY2VsbF9pZBgBIAEoBBIcChRjdXJy",
                    "ZW50X3RpbWVzdGFtcF9tcxgCIAEoAxIsCgVmb3J0cxgDIAMoCzIdLlBPR09Q",
                    "cm90b3MuTWFwLkZvcnQuRm9ydERhdGESMAoMc3Bhd25fcG9pbnRzGAQgAygL",
                    "MhouUE9HT1Byb3Rvcy5NYXAuU3Bhd25Qb2ludBIXCg9kZWxldGVkX29iamVj",
                    "dHMYBiADKAkSGQoRaXNfdHJ1bmNhdGVkX2xpc3QYByABKAgSOAoOZm9ydF9z",
                    "dW1tYXJpZXMYCCADKAsyIC5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRTdW1t",
                    "YXJ5EjoKFmRlY2ltYXRlZF9zcGF3bl9wb2ludHMYCSADKAsyGi5QT0dPUHJv",
                    "dG9zLk1hcC5TcGF3blBvaW50EjoKDXdpbGRfcG9rZW1vbnMYBSADKAsyIy5Q",
                    "T0dPUHJvdG9zLk1hcC5Qb2tlbW9uLldpbGRQb2tlbW9uEj4KEmNhdGNoYWJs",
                    "ZV9wb2tlbW9ucxgKIAMoCzIiLlBPR09Qcm90b3MuTWFwLlBva2Vtb24uTWFw",
                    "UG9rZW1vbhI+Cg9uZWFyYnlfcG9rZW1vbnMYCyADKAsyJS5QT0dPUHJvdG9z",
                    "Lk1hcC5Qb2tlbW9uLk5lYXJieVBva2Vtb24iMQoKU3Bhd25Qb2ludBIQCghs",
                    "YXRpdHVkZRgCIAEoARIRCglsb25naXR1ZGUYAyABKAEqRQoQTWFwT2JqZWN0",
                    "c1N0YXR1cxIQCgxVTlNFVF9TVEFUVVMQABILCgdTVUNDRVNTEAESEgoOTE9D",
                    "QVRJT05fVU5TRVQQAlAAUAFiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[]
                {
                    global::POGOProtos.Map.Fort.POGOProtosMapFortReflection.Descriptor,
                    global::POGOProtos.Map.Pokemon.POGOProtosMapPokemonReflection.Descriptor,
                },
                new pbr::GeneratedClrTypeInfo(new[] {typeof (global::POGOProtos.Map.MapObjectsStatus),},
                    new pbr::GeneratedClrTypeInfo[]
                    {
                        new pbr::GeneratedClrTypeInfo(typeof (global::POGOProtos.Map.MapCell),
                            global::POGOProtos.Map.MapCell.Parser,
                            new[]
                            {
                                "S2CellId", "CurrentTimestampMs", "Forts", "SpawnPoints", "DeletedObjects",
                                "IsTruncatedList", "FortSummaries", "DecimatedSpawnPoints", "WildPokemons",
                                "CatchablePokemons", "NearbyPokemons"
                            }, null, null, null),
                        new pbr::GeneratedClrTypeInfo(typeof (global::POGOProtos.Map.SpawnPoint),
                            global::POGOProtos.Map.SpawnPoint.Parser, new[] {"Latitude", "Longitude"}, null, null, null)
                    }));
        }

        #endregion
    }

    #region Enums

    public enum MapObjectsStatus
    {
        [pbr::OriginalName("UNSET_STATUS")] UnsetStatus = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 2,
    }

    #endregion

    #region Messages

    public sealed partial class MapCell : pb::IMessage<MapCell>
    {
        /// <summary>Field number for the "s2_cell_id" field.</summary>
        public const int S2CellIdFieldNumber = 1;

        /// <summary>Field number for the "current_timestamp_ms" field.</summary>
        public const int CurrentTimestampMsFieldNumber = 2;

        /// <summary>Field number for the "forts" field.</summary>
        public const int FortsFieldNumber = 3;

        /// <summary>Field number for the "spawn_points" field.</summary>
        public const int SpawnPointsFieldNumber = 4;

        /// <summary>Field number for the "deleted_objects" field.</summary>
        public const int DeletedObjectsFieldNumber = 6;

        /// <summary>Field number for the "is_truncated_list" field.</summary>
        public const int IsTruncatedListFieldNumber = 7;

        /// <summary>Field number for the "fort_summaries" field.</summary>
        public const int FortSummariesFieldNumber = 8;

        /// <summary>Field number for the "decimated_spawn_points" field.</summary>
        public const int DecimatedSpawnPointsFieldNumber = 9;

        /// <summary>Field number for the "wild_pokemons" field.</summary>
        public const int WildPokemonsFieldNumber = 5;

        /// <summary>Field number for the "catchable_pokemons" field.</summary>
        public const int CatchablePokemonsFieldNumber = 10;

        /// <summary>Field number for the "nearby_pokemons" field.</summary>
        public const int NearbyPokemonsFieldNumber = 11;

        private static readonly pb::MessageParser<MapCell> _parser = new pb::MessageParser<MapCell>(() => new MapCell());

        private static readonly pb::FieldCodec<global::POGOProtos.Map.Fort.FortData> _repeated_forts_codec
            = pb::FieldCodec.ForMessage(26, global::POGOProtos.Map.Fort.FortData.Parser);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.SpawnPoint> _repeated_spawnPoints_codec
            = pb::FieldCodec.ForMessage(34, global::POGOProtos.Map.SpawnPoint.Parser);

        private static readonly pb::FieldCodec<string> _repeated_deletedObjects_codec
            = pb::FieldCodec.ForString(50);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.Fort.FortSummary> _repeated_fortSummaries_codec
            = pb::FieldCodec.ForMessage(66, global::POGOProtos.Map.Fort.FortSummary.Parser);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.SpawnPoint> _repeated_decimatedSpawnPoints_codec
            = pb::FieldCodec.ForMessage(74, global::POGOProtos.Map.SpawnPoint.Parser);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.Pokemon.WildPokemon> _repeated_wildPokemons_codec
            = pb::FieldCodec.ForMessage(42, global::POGOProtos.Map.Pokemon.WildPokemon.Parser);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.Pokemon.MapPokemon>
            _repeated_catchablePokemons_codec
                = pb::FieldCodec.ForMessage(82, global::POGOProtos.Map.Pokemon.MapPokemon.Parser);

        private static readonly pb::FieldCodec<global::POGOProtos.Map.Pokemon.NearbyPokemon>
            _repeated_nearbyPokemons_codec
                = pb::FieldCodec.ForMessage(90, global::POGOProtos.Map.Pokemon.NearbyPokemon.Parser);

        private readonly pbc::RepeatedField<global::POGOProtos.Map.Pokemon.MapPokemon> catchablePokemons_ =
            new pbc::RepeatedField<global::POGOProtos.Map.Pokemon.MapPokemon>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint> decimatedSpawnPoints_ =
            new pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint>();

        private readonly pbc::RepeatedField<string> deletedObjects_ = new pbc::RepeatedField<string>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.Fort.FortData> forts_ =
            new pbc::RepeatedField<global::POGOProtos.Map.Fort.FortData>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.Fort.FortSummary> fortSummaries_ =
            new pbc::RepeatedField<global::POGOProtos.Map.Fort.FortSummary>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.Pokemon.NearbyPokemon> nearbyPokemons_ =
            new pbc::RepeatedField<global::POGOProtos.Map.Pokemon.NearbyPokemon>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint> spawnPoints_ =
            new pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint>();

        private readonly pbc::RepeatedField<global::POGOProtos.Map.Pokemon.WildPokemon> wildPokemons_ =
            new pbc::RepeatedField<global::POGOProtos.Map.Pokemon.WildPokemon>();

        private long currentTimestampMs_;
        private bool isTruncatedList_;
        private ulong s2CellId_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapCell()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapCell(MapCell other) : this()
        {
            s2CellId_ = other.s2CellId_;
            currentTimestampMs_ = other.currentTimestampMs_;
            forts_ = other.forts_.Clone();
            spawnPoints_ = other.spawnPoints_.Clone();
            deletedObjects_ = other.deletedObjects_.Clone();
            isTruncatedList_ = other.isTruncatedList_;
            fortSummaries_ = other.fortSummaries_.Clone();
            decimatedSpawnPoints_ = other.decimatedSpawnPoints_.Clone();
            wildPokemons_ = other.wildPokemons_.Clone();
            catchablePokemons_ = other.catchablePokemons_.Clone();
            nearbyPokemons_ = other.nearbyPokemons_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MapCell> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Map.POGOProtosMapReflection.Descriptor.MessageTypes[0]; }
        }

        /// <summary>
        ///     S2 geographic area that the cell covers (http://s2map.com/)
        ///     (https://code.google.com/archive/p/s2-geometry-library/)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong S2CellId
        {
            get { return s2CellId_; }
            set { s2CellId_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long CurrentTimestampMs
        {
            get { return currentTimestampMs_; }
            set { currentTimestampMs_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.Fort.FortData> Forts
        {
            get { return forts_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint> SpawnPoints
        {
            get { return spawnPoints_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> DeletedObjects
        {
            get { return deletedObjects_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool IsTruncatedList
        {
            get { return isTruncatedList_; }
            set { isTruncatedList_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.Fort.FortSummary> FortSummaries
        {
            get { return fortSummaries_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.SpawnPoint> DecimatedSpawnPoints
        {
            get { return decimatedSpawnPoints_; }
        }

        /// <summary>
        ///     Pokemon within 2 steps or less.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.Pokemon.WildPokemon> WildPokemons
        {
            get { return wildPokemons_; }
        }

        /// <summary>
        ///     Pokemon within 1 step or none.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.Pokemon.MapPokemon> CatchablePokemons
        {
            get { return catchablePokemons_; }
        }

        /// <summary>
        ///     Pokemon farther away than 2 steps, but still in the area.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Map.Pokemon.NearbyPokemon> NearbyPokemons
        {
            get { return nearbyPokemons_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MapCell Clone()
        {
            return new MapCell(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MapCell other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (S2CellId != other.S2CellId) return false;
            if (CurrentTimestampMs != other.CurrentTimestampMs) return false;
            if (!forts_.Equals(other.forts_)) return false;
            if (!spawnPoints_.Equals(other.spawnPoints_)) return false;
            if (!deletedObjects_.Equals(other.deletedObjects_)) return false;
            if (IsTruncatedList != other.IsTruncatedList) return false;
            if (!fortSummaries_.Equals(other.fortSummaries_)) return false;
            if (!decimatedSpawnPoints_.Equals(other.decimatedSpawnPoints_)) return false;
            if (!wildPokemons_.Equals(other.wildPokemons_)) return false;
            if (!catchablePokemons_.Equals(other.catchablePokemons_)) return false;
            if (!nearbyPokemons_.Equals(other.nearbyPokemons_)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (S2CellId != 0UL)
            {
                output.WriteRawTag(8);
                output.WriteUInt64(S2CellId);
            }
            if (CurrentTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(CurrentTimestampMs);
            }
            forts_.WriteTo(output, _repeated_forts_codec);
            spawnPoints_.WriteTo(output, _repeated_spawnPoints_codec);
            wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
            deletedObjects_.WriteTo(output, _repeated_deletedObjects_codec);
            if (IsTruncatedList != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(IsTruncatedList);
            }
            fortSummaries_.WriteTo(output, _repeated_fortSummaries_codec);
            decimatedSpawnPoints_.WriteTo(output, _repeated_decimatedSpawnPoints_codec);
            catchablePokemons_.WriteTo(output, _repeated_catchablePokemons_codec);
            nearbyPokemons_.WriteTo(output, _repeated_nearbyPokemons_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (S2CellId != 0UL)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt64Size(S2CellId);
            }
            if (CurrentTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentTimestampMs);
            }
            size += forts_.CalculateSize(_repeated_forts_codec);
            size += spawnPoints_.CalculateSize(_repeated_spawnPoints_codec);
            size += deletedObjects_.CalculateSize(_repeated_deletedObjects_codec);
            if (IsTruncatedList != false)
            {
                size += 1 + 1;
            }
            size += fortSummaries_.CalculateSize(_repeated_fortSummaries_codec);
            size += decimatedSpawnPoints_.CalculateSize(_repeated_decimatedSpawnPoints_codec);
            size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
            size += catchablePokemons_.CalculateSize(_repeated_catchablePokemons_codec);
            size += nearbyPokemons_.CalculateSize(_repeated_nearbyPokemons_codec);
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MapCell other)
        {
            if (other == null)
            {
                return;
            }
            if (other.S2CellId != 0UL)
            {
                S2CellId = other.S2CellId;
            }
            if (other.CurrentTimestampMs != 0L)
            {
                CurrentTimestampMs = other.CurrentTimestampMs;
            }
            forts_.Add(other.forts_);
            spawnPoints_.Add(other.spawnPoints_);
            deletedObjects_.Add(other.deletedObjects_);
            if (other.IsTruncatedList != false)
            {
                IsTruncatedList = other.IsTruncatedList;
            }
            fortSummaries_.Add(other.fortSummaries_);
            decimatedSpawnPoints_.Add(other.decimatedSpawnPoints_);
            wildPokemons_.Add(other.wildPokemons_);
            catchablePokemons_.Add(other.catchablePokemons_);
            nearbyPokemons_.Add(other.nearbyPokemons_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                    {
                        S2CellId = input.ReadUInt64();
                        break;
                    }
                    case 16:
                    {
                        CurrentTimestampMs = input.ReadInt64();
                        break;
                    }
                    case 26:
                    {
                        forts_.AddEntriesFrom(input, _repeated_forts_codec);
                        break;
                    }
                    case 34:
                    {
                        spawnPoints_.AddEntriesFrom(input, _repeated_spawnPoints_codec);
                        break;
                    }
                    case 42:
                    {
                        wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
                        break;
                    }
                    case 50:
                    {
                        deletedObjects_.AddEntriesFrom(input, _repeated_deletedObjects_codec);
                        break;
                    }
                    case 56:
                    {
                        IsTruncatedList = input.ReadBool();
                        break;
                    }
                    case 66:
                    {
                        fortSummaries_.AddEntriesFrom(input, _repeated_fortSummaries_codec);
                        break;
                    }
                    case 74:
                    {
                        decimatedSpawnPoints_.AddEntriesFrom(input, _repeated_decimatedSpawnPoints_codec);
                        break;
                    }
                    case 82:
                    {
                        catchablePokemons_.AddEntriesFrom(input, _repeated_catchablePokemons_codec);
                        break;
                    }
                    case 90:
                    {
                        nearbyPokemons_.AddEntriesFrom(input, _repeated_nearbyPokemons_codec);
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as MapCell);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (S2CellId != 0UL) hash ^= S2CellId.GetHashCode();
            if (CurrentTimestampMs != 0L) hash ^= CurrentTimestampMs.GetHashCode();
            hash ^= forts_.GetHashCode();
            hash ^= spawnPoints_.GetHashCode();
            hash ^= deletedObjects_.GetHashCode();
            if (IsTruncatedList != false) hash ^= IsTruncatedList.GetHashCode();
            hash ^= fortSummaries_.GetHashCode();
            hash ^= decimatedSpawnPoints_.GetHashCode();
            hash ^= wildPokemons_.GetHashCode();
            hash ^= catchablePokemons_.GetHashCode();
            hash ^= nearbyPokemons_.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    public sealed partial class SpawnPoint : pb::IMessage<SpawnPoint>
    {
        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 2;

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 3;

        private static readonly pb::MessageParser<SpawnPoint> _parser =
            new pb::MessageParser<SpawnPoint>(() => new SpawnPoint());

        private double latitude_;
        private double longitude_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SpawnPoint()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SpawnPoint(SpawnPoint other) : this()
        {
            latitude_ = other.latitude_;
            longitude_ = other.longitude_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<SpawnPoint> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Map.POGOProtosMapReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Latitude
        {
            get { return latitude_; }
            set { latitude_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Longitude
        {
            get { return longitude_; }
            set { longitude_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SpawnPoint Clone()
        {
            return new SpawnPoint(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(SpawnPoint other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Latitude != other.Latitude) return false;
            if (Longitude != other.Longitude) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Latitude != 0D)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Latitude);
            }
            if (Longitude != 0D)
            {
                output.WriteRawTag(25);
                output.WriteDouble(Longitude);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (Latitude != 0D)
            {
                size += 1 + 8;
            }
            if (Longitude != 0D)
            {
                size += 1 + 8;
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(SpawnPoint other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Latitude != 0D)
            {
                Latitude = other.Latitude;
            }
            if (other.Longitude != 0D)
            {
                Longitude = other.Longitude;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 17:
                    {
                        Latitude = input.ReadDouble();
                        break;
                    }
                    case 25:
                    {
                        Longitude = input.ReadDouble();
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as SpawnPoint);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (Latitude != 0D) hash ^= Latitude.GetHashCode();
            if (Longitude != 0D) hash ^= Longitude.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    #endregion
}

#endregion Designer generated code