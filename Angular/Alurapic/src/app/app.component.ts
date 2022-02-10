import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Alurapic';

  photos = [
    {
      desc:'Lesma Azul',
      url:'https://d5y9g7a5.rocketcdn.me/wp-content/uploads/2021/03/lesma-do-mar-o-que-e-principais-caracteristicas-desse-animal-peculiar.jpg',
    },
    {
      desc:'Lesma Rosa',
      url:'https://static.natgeo.pt/files/styles/image_3200/public/170327-specials-tos-nudibranch-goby-PT~~~~~pt~mux~~1.jpg?w=1900&h=1069',
    },
  ];
}
