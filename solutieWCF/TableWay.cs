using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class TableWay : InterfataTableWay
    {
        public bool CreateTableWay(Media media, Tags tag, TagType tagType)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTableWay(Media media)
        {
            throw new NotImplementedException();
        }

        public List<TableWays> GetTableWays(Media media)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTableWaysIdMediaAfterIdTag(int tagId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId)
        {
            throw new NotImplementedException();
        }

        public int GetTableWaysIdTagsCategory(int tagId)
        {
            throw new NotImplementedException();
        }

        public Tags GetTableWaysIdTagsCategoryForDATE(int mediaId)
        {
            throw new NotImplementedException();
        }

        public int GetTableWaysTagsId(int mediaId)
        {
            throw new NotImplementedException();
        }
    }
}
