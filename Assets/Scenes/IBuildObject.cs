public interface IBuildObject
{
    // Start is called before the first frame update
    void ReadInput();

    float Rotation { get; }
    float Thrust { get; }

}
