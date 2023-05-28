using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
     class MyIterator : IEnumerator
    {
        private List<Train_Info> Trains;
        private int index = -1;
        public MyIterator(List<Train_Info> tr)
        {
           Trains = tr;
        }
        public bool MoveNext()
        {
            if (index == Trains.Count - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get { return Trains[index]; }
        }
    }
  
}
