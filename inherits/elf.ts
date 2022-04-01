import { Humanoid } from "./humanoid.ts";
import { IGetInfo } from "./IGetInfo.ts";

export class Elf extends Humanoid implements IGetInfo {
  private hornyness: number;

  constructor(
    name: string,
    skinColor: string,
    hairColor: string,
    eyeColor: string,
    height: number,
    weight: number,
  ) {
    super(name, skinColor, hairColor, eyeColor, height, weight);
    this.hornyness = Math.floor(Math.random() * (10));
  }

  getInfo(): string {
    return `${this.name} is a elf with ${this.getHeight()} cm height, ${this.hairColor} hair, ${this.eyeColor} eyes, ${this.skinColor} skin, ${this.getHornyness()} horny.`;
  }

  public getHornyness(): number {
    const hornynessNow = Math.floor(Math.random() * (10)) * this.hornyness;
    if (hornynessNow % 2 === 0) {
      return 0;
    }
    return hornynessNow;
  }
}
