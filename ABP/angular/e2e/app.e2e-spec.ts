import { SISTemplatePage } from './app.po';

describe('SIS App', function() {
  let page: SISTemplatePage;

  beforeEach(() => {
    page = new SISTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
