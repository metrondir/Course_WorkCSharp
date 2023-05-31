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
        private List<Train_Info> trains;
        private int index = -1;
        public MyIterator(List<Train_Info> tr)
        {
           trains = tr;
        }
        public bool MoveNext()
        {
            if (index == trains.Count - 1)
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
            get { return trains[index]; }
        }
    }
  
}
