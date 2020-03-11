private calcWeeks(){
    const data = new Date();
    data.setDate(1);
    if (data.getDay() === 0 && this.getDays(data.getMonth(), data.getFullYear()) === 28) {
      console.log("4 semanas - 28");
    } else if (this.getDays(data.getMonth(), data.getFullYear()) === 28) {
      console.log("5 semanas - 28");
    }

    if (data.getDay() === 6 && this.getDays(data.getMonth(), data.getFullYear()) === 30) {
      console.log("6 semanas - 30");
    } else  if (this.getDays(data.getMonth(), data.getFullYear()) === 30) {
      console.log("5 semanas - 30");
    }

     if ((data.getDay() === 6 || data.getDay() === 5) && this.getDays(data.getMonth(), data.getFullYear()) === 31) {
      console.log("6 semanas - 31");
    } else  if (this.getDays(data.getMonth(), data.getFullYear()) === 31) {
      console.log("5 semanas - 31");
    }
  }
