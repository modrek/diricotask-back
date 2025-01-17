﻿using diricoAPIs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diricoAPIs.Domain.Repositories
{
    public interface IAssetRepository : IRepository<AssetModel>
    {

        List<FolderResponse> GetFolders(Guid? CurrentLevelKey);

        List<FolderContentResponse> GetFolderContents(bool showDetail, Guid FolderId);

        List<FolderContentResponse> GetRelatedAssets(Guid AssetId);

        MetadataResponse GetAssetMetadata(Guid AssetId);

        AssetModel GetEntityByPath(string path);
    }
}
