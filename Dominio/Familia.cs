public class Familia
{
    public Guid Id { get; private set; }
    public Pretendente Titular { get; private set; }
    public Pretendente? Conjuge { get; private set; }
    private List<Dependente> _dependentes = new List<Dependente>();
    public IEnumerable<Dependente> Dependentes => _dependentes;

    public Familia(Pretendente titular, IEnumerable<Dependente> dependentes, Pretendente? conjuge = null)
    {
        Id = Guid.NewGuid();
        Titular = titular;
        Conjuge = conjuge;
        _dependentes.AddRange(dependentes);
    }

}

public class Dependente{
    
}