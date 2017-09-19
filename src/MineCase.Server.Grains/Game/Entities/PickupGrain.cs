﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MineCase.Server.Game.Entities.Components;
using MineCase.Server.World;
using Orleans;

namespace MineCase.Server.Game.Entities
{
    internal class PickupGrain : EntityGrain, IPickup
    {
        protected override async Task InitializeComponents()
        {
            await base.InitializeComponents();
            await SetComponent(new PickupMetadataComponent());
        }

        /*
        public async Task CollectBy(IPlayer player)
        {
            var after = await player.Collect(EntityId, _metadata.Item);
            if (after.IsEmpty)
            {
                var chunkPos = GetChunkPosition();
                await GrainFactory.GetGrain<ICollectableFinder>(World.MakeCollectableFinderKey(chunkPos.x, chunkPos.z)).Unregister(this);
                await GetBroadcastGenerator().DestroyEntities(new[] { EntityId });
                DeactivateOnIdle();
            }
            else if (_metadata.Item.ItemCount != after.ItemCount)
            {
                await SetItem(after);
            }
        }

        public async Task Register()
        {
            var chunkPos = GetChunkPosition();
            await GrainFactory.GetGrain<ICollectableFinder>(World.MakeCollectableFinderKey(chunkPos.x, chunkPos.z)).Register(this);
        }

        public async Task SetItem(Slot item)
        {
            _metadata.Item = item;
            await GetBroadcastGenerator().EntityMetadata(EntityId, _metadata);
        }

        public async Task Spawn(Guid uuid, Vector3 position)
        {
            UUID = uuid;
            await SetPosition(position);
            await GetBroadcastGenerator().SpawnObject(EntityId, uuid, 2, position, 0, 0, 0);
        }*/
    }
}
