## Submission description

I wanted to test RightToLeft

### What went well

I was surprised how RightToLeft is supported, When I set FlowDirection="RightToLeft", The first page was as expected,
Excellent job Xamarin team, Go Ahead

### What didn't go well

with VS2017, the app crashes immediatly, I couldn't fix it.
with VS2019, when i write as following, i get exception with "cast not valid" message:
<CarouselView FlowDirection="RightToLeft">
    <CarouselView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                //My template
            </ViewCell>
        </DataTemplate>
    </CarouselView.ItemTemplate>
</CarouselView>
 
 but no crashed when i write as following:
 <CarouselView FlowDirection="RightToLeft">
    <CarouselView.ItemTemplate>
        <DataTemplate>
            //My template
        </DataTemplate>
    </CarouselView.ItemTemplate>
</CarouselView>
 
### Missing or desired things

Nothing not mentioned by other PRs

### Anything else

Very good job, Go Ahead Xamarin

### Take out a survey for some goodies

_Please visit this [link](https://www.surveymonkey.com/r/KVF5X6G) to take a survey. If you provide your contact information, we'll send you some swag!_
