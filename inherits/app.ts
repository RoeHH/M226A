import {
  Checkbox,
  Input,
  Number,
  prompt,
  Secret,
} from "https://deno.land/x/cliffy/prompt/mod.ts";

import { Elf } from "./elf.ts";
import { Human } from "./human.ts";
import { IGetInfo } from "./IGetInfo.ts";

const result = await prompt([{
  name: "name",
  message: "What's your name?",
  type: Input,
}, {
  name: "race",
  message: "What's your race",
  type: Checkbox,
  maxOptions: 1,
  minOptions: 1,
  options: ["elf", "human"],
}, {
  name: "skin",
  message: "What is your Skin color?",
  type: Checkbox,
  maxOptions: 1,
  minOptions: 1,
  options: ["black", "white", "red", "yellow", "blue"],
}, {
  name: "eye",
  message: "What is your Eye color?",
  type: Checkbox,
  maxOptions: 1,
  minOptions: 1,
  options: ["black", "white", "red", "yellow", "blue"],
}, {
  name: "height",
  message: "What's your height?",
  type: Number,
}, {
  name: "weight",
  message: "What's your weight?",
  type: Secret,
}]);

let info: IGetInfo;

if(result.name != undefined && result.race != undefined && result.skin != undefined && result.eye != undefined && result.height != undefined && result.weight != undefined){
    if (result.race[0] === "elf") {
        info = new Elf(result.name, result.skin[0], "red", result.eye[0], result.height, parseInt(result.weight));
    }else{
        info = new Human(result.name, result.skin[0], "blue", result.eye[0], result.height, parseInt(result.weight));
    }
    console.log(info.getInfo());
}
