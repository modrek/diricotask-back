﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace diricoAPIs.Domain.Models
{

    public class GetListRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string Expression { get; set; }
    }
    public class FolderRequest
    {        
        public Guid? CurrentLevelKey { get; set; }
    }    

    public class FolderResponse
    {
        public Guid? FolderId { get; set; }
        public string FolderName { get; set; }
    }

    public class FolderContentRequest
    {     
        public Guid FolderId { get; set; }
    }
    public class FolderContentResponse
    {
        public Guid AssetID { get; set; }
        public string AssetName { get; set; }
        public AssetTypes AssetType { get; set; }
        public string AssetPath { get; set; }
    }

    public class UploadAssetRequest
    {        
        public AssetTypes AssetType { get; set; }
    }

    public class MetadataRequest
    {       
        public Guid AssetId { get; set; }
    }
    public class MetadataResponse
    {
        public string Metadata { get; set; }

    }

}