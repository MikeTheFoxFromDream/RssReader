   M S B A M L   `   `   `  ����D  @RSSCtecka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RSSCtecka	RSSCtecka  5   	       RSSCtecka.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RSSCtecka     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��900��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $��8* �6   �� 5      $
��1.3* �6   .+�5   
   �� -   5        $��	lvEntries��5      $��0��5      $��2��6    ���	#FF3A3838���	#FF3A3838$	��Top=�5      $��0q�62      	TopicCard#��[  5      $��0,5,0,0q�5      6%   �� 5   
   -   5        $��2��5      ���	#FF515050
�������$��Arial)�5    $   $��18(�5!      $��0q�6   .��6S   Nové téma5#      �� 5%   
   ���	#FF515050$��0��6(   $��1��65   ._�5&      �  5'      �� 5(      $��* �6'   �� 5)      $��3* �6'   �� 5*      $��* �6'   �� 5+      $��3* �6'   �� 5,      $��* �6'   .+�5/      �� -   5        $��4��5/      ���	#FF515050
�������$��1q�50   ,   
���   �$��18(�51   -   $	��⟳��52      6&   53      55      �� 57   
   -   5         ��Name$ 
lvArticles��5:      $��1��57      $��2��6    $��1��61   ���	#FF292727$��0q�58   *     ArticleCard#��[ 59      5<      5>      5?      