import shuffle from "https://deno.land/x/shuffle/mod.ts";

export class Adventurer {
  public strength: number;
  public dexterity: number;
  public constitution: number;
  public intelligence: number;
  public wisdom: number;
  public charisma: number;

  constructor() {
    [
      this.strength,
      this.dexterity,
      this.constitution,
      this.intelligence,
      this.wisdom,
      this.charisma,
    ] = shuffle([1, 2, 3, 4, 5, 6]);
  }
}
