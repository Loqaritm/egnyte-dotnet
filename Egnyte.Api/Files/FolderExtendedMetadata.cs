﻿namespace Egnyte.Api.Files
{
    using System;
    using System.Collections.Generic;

    public class FolderExtendedMetadata : FolderMetadata
    {
        internal FolderExtendedMetadata(
            string name,
            int count,
            int offset,
            string path,
            string folderId,
            string folderDescription,
            int totalCount,
            DateTime lastModified,
            bool restrictMoveDelete,
            string publicLinks,
            string[] allowedFileLinkTypes,
            string[] allowedFolderLinkTypes,
            List<FolderMetadata> folders,
            List<FileBasicMetadata> files,
            FileOrFolderCustomMetadata customMetadata)
            : base(name, lastModified, path, folderId, allowedFileLinkTypes, allowedFolderLinkTypes, customMetadata)
        {
            Count = count;
            Offset = offset;
            FolderDescription = folderDescription;
            TotalCount = totalCount;
            RestrictMoveDelete = restrictMoveDelete;
            PublicLinks = publicLinks;
            Folders = folders ?? new List<FolderMetadata>();
            Files = files ?? new List<FileBasicMetadata>();
        }

        public int Count { get; private set; }

        public int Offset { get; private set; }

        public string FolderDescription { get; private set; }

        public int TotalCount { get; private set; }

        public bool RestrictMoveDelete { get; private set; }

        public string PublicLinks { get; private set; }

        public List<FolderMetadata> Folders { get; private set; }

        public List<FileBasicMetadata> Files { get; private set; }
    }
}
