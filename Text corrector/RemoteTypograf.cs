using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLebedevStudio
{
    public class RemoteTypograf
    {
        private int _entityType;
        private bool _useBr;
        private bool _useP;
        private int _maxNobr;

        public RemoteTypograf()
        {
            _entityType = 4;
            _useBr = true;
            _useP = true;
            _maxNobr = 3;
        }

        public void htmlEntities()
        {
            _entityType = 1;
        }
        public void xmlEntities()
        {
            _entityType = 2;
        }
        public void mixedEntities()
        {
            _entityType = 4;
        }
        public void noEntities()
        {
            _entityType = 3;
        }
        public void br(bool value)
        {
            _useBr = (bool)value;
        }
        public void p(bool value)
        {
            _useP = value;
        }
        public void nobr(int value)
        {
            _maxNobr = value;
        }

        public System.String ProcessText(System.String text)
        {
            ArtLebedevStudio.WebServices.Typograf remoteTypograf = new ArtLebedevStudio.WebServices.Typograf();

            return remoteTypograf.ProcessText(text, _entityType, _useBr, _useP, _maxNobr);
        }
    }

}
