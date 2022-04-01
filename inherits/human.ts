import { Humanoid } from "./humanoid.ts";
import { IGetInfo } from "./IGetInfo.ts";

export class Human extends Humanoid implements IGetInfo {
  private racism: number;

  constructor(
    name: string,
    skinColor: string,
    hairColor: string,
    eyeColor: string,
    height: number,
    weight: number,
  ) {
    super(name, skinColor, hairColor, eyeColor, height, weight);
    this.racism = Math.floor(Math.random() * (100));
  }

  getInfo(): string {
    return `${this.name} is a human with ${this.getHeight()} cm height, ${this.hairColor} hair, ${this.eyeColor} eyes, ${this.skinColor} skin, ${this.getRacism()} racism.`;
  }

  public getRacism(): number {
    if (this.racism < 20) {
      return 0;
    }
    return this.racism - (this.charisma * 5);
  }
}
