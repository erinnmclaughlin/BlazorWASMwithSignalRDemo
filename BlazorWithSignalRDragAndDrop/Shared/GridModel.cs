namespace BlazorWithSignalRDragAndDrop.Shared
{
    public class GridModel
    {
        private int _dimension = 3;
        public int Dimension => _dimension;

        public int CurrentRow { get; set; }
        public int CurrentCol { get; set; }
    }
}
