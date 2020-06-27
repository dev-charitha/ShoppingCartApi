import { Component } from '@angular/core';
import { Title, Meta } from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'ShoppingCartDesignPoc';

  constructor(private titleService: Title, private metaService: Meta) {
    titleService.setTitle('ShoppingMore');
    metaService.updateTag({
      name: 'viewport',
      content: 'width=device-width, initial-scale=1.0',
    });
    metaService.addTag(
      { name: 'description', content: 'Angular Shopping Cart POC' },
      true
    );
    metaService.addTag(
      { name: 'author', content: 'Charitha Wickramasinghe' },
      true
    );
  }
}
