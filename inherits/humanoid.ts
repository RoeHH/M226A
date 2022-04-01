import { Adventurer } from "./adventurer.ts";

export class Humanoid extends Adventurer {
  public name: string;
  public skinColor: string;
  public hairColor: string;
  public eyeColor: string;
  private height: number;
  private weight: number;

  constructor(
    name: string,
    skinColor: string,
    hairColor: string,
    eyeColor: string,
    height: number,
    weight: number,
  ) {
    super();
    this.name = name;
    this.skinColor = skinColor;
    this.hairColor = hairColor;
    this.eyeColor = eyeColor;
    this.height = height;
    this.weight = weight;
  }

  public getHeight(): number {
    return Math.floor(Math.random() * (this.weight / 10)) + this.height;
  }
}
