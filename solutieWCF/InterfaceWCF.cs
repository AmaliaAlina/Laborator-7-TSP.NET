using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    [ServiceContract]
    interface InterfaceMedia
    {
        [OperationContract]
        Boolean CreateMedia(String pathName);
        [OperationContract]
        Boolean DeleteMedia(String mediaPath);
        [OperationContract]
        Boolean DeleteMedia(Media media);
        [OperationContract]
        Boolean UpdateMedia(Media newMedia);
        [OperationContract]
        Media GetMedia(String mediaPath);
        [OperationContract]
        Media GetMedia(int mediaID);
        [OperationContract]
        int GetMediaId(String mediaPath);
        [OperationContract]
        List<Media> GetAllMedia();
        [OperationContract]
        List<Media> GetAllMedia(int media);
        [OperationContract]
        List<Media> GetAllMedia(string mediaName);
    }

    [ServiceContract]
    interface InterfaceTag
    {
        [OperationContract]
        Boolean CreateTag(string valueOfTag);
        [OperationContract]
        Tags CreateDateTag(string date);
        [OperationContract]
        Tags CreateTagAnReturnTag(string valueOfTag);
        [OperationContract]
        Boolean DeleteTag(Tags deletedTag);
        [OperationContract]
        Boolean UpdateTag(Tags updatedTag);
        [OperationContract]
        Tags GetTag(string givenTagValue);
        [OperationContract]
        List<Tags> GetTagAll();
    }

    [ServiceContract]
    interface InterfaceTagTypes 
    {
        [OperationContract]
        Boolean Create(string valueOfTag);
        [OperationContract]
        TagType CreateAndReturn(string valueOfTag);
        [OperationContract]
        TagType CreateTagTypeAndReturnIt(string valueOfTag);
        [OperationContract]
        Boolean DeleteTagType(TagType givenTagType);
        [OperationContract]
        Boolean UpdateTagType(TagType newTagType);
        [OperationContract]
        TagType GetTagTypes(int givenId);
        [OperationContract]
        TagType GetTagTypes(string givenValueTagType);
        
    }

    [ServiceContract]
    interface InterfataTableWay
    {
        [OperationContract]
        Boolean CreateTableWay(Media media, Tags tag, TagType tagType);
        [OperationContract]
        Boolean DeleteTableWay(Media media);
        [OperationContract]
        List<TableWays> GetTableWays(Media media);
        [OperationContract]
        int GetTableWaysTagsId(int mediaId);
        [OperationContract]
        int GetTableWaysIdTagsCategory(int tagId);
        [OperationContract]
        Tags GetTableWaysIdTagsCategoryForDATE(int mediaId);
        [OperationContract]
        List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId);
        [OperationContract]
        List<int> GetTableWaysIdMediaAfterIdTag(int tagId);
    }

    [ServiceContract]
    interface IPostComment : InterfaceMedia, InterfaceTag, InterfaceTagTypes, InterfataTableWay
    {
    }
}
