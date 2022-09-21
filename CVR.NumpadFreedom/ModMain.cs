using MelonLoader;

namespace CVR.NumpadFreedomMod;

public sealed class ModMain : MelonMod {
  Env _env;
  public override void OnApplicationStart() {
    _env = new Env();
  }
}